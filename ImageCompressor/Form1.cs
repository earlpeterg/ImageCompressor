using Dasync.Collections;
using EarlPeterG;
using EarlPeterG.IO;
using EarlPeterG.Win;
using EarlPeterG.Win.Forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {
        public string[] Args { get; set; }

        private readonly string iniFilePath = Path.Combine(Program.GetAppDataPath(), "settings.ini");
        private readonly string errorLogPath = Path.Combine(Program.GetAppDataPath(), "error.log");
        private readonly string jpegOptimPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\jpegoptim.exe");
        private readonly string guetzlix86Path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\guetzli_windows_x86.exe");
        private readonly string optiPngPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\optipng.exe");
        private readonly decimal memoryLimit = Math.Round(new ComputerInfo().TotalPhysicalMemory * 0.75m / 1048576);
        private CancellationTokenSource cancellationToken = new CancellationTokenSource();

        private int currentProcessId = -1;
        private long uncompressedTotal = 0;
        private long compressedTotal = 0;

        #region "Local Functions"
        /// <summary>
        /// Checks if file extension is supported
        /// </summary>
        private bool IsValidFile(string file)
        {
            var extensions = new string[] { ".jpeg", ".jpg", ".png" };
            try {
                var fileInfo = new FileInfo(file);
                return extensions.Contains(fileInfo.Extension.ToLower());
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Enumerate files and folders inside a directory
        /// </summary>
        /// <param name="path">The root directory where the program will start processing files</param>
        public void Enumerate(string path)
        {
            try {
                var attr = File.GetAttributes(path);
                if (attr.HasFlag(FileAttributes.Directory)) {
                    foreach (var file in Directory.GetFiles(path).Where(file => IsValidFile(file))) {
                        DataGridFilesAddRow(file);
                    }

                    foreach (string directory in Directory.GetDirectories(path)) {
                        if (cancellationToken.IsCancellationRequested) { return; }
                        Enumerate(directory);
                    }

                    return;
                }
            } catch { }

            if (IsValidFile(path)) { DataGridFilesAddRow(path); }
        }

        public void Enumerate(IEnumerable<string> paths) {
            foreach(var path in paths) { Enumerate(path); }
        }

        private void ToggleSettings()
        {
            boxSettings.Visible = !boxSettings.Visible;
            menuBarTop.Enabled = !menuBarTop.Enabled;
            menuBarSecondary.Enabled = !menuBarSecondary.Enabled;
            dataGridFiles.Enabled = !dataGridFiles.Enabled;
        }
        private void ToggleStartStopMenu()
        {
            menuBarTop.Enabled = !menuBarTop.Enabled;
            startToolStripMenuItem.Visible = !startToolStripMenuItem.Visible;
            stopToolStripMenuItem.Visible = !stopToolStripMenuItem.Visible;
            dataGridFiles.Enabled = !dataGridFiles.Enabled;
            ToggleWaitCursor();
        }
        private void ToggleWaitCursor() => UseWaitCursor = !UseWaitCursor;

        private void ResetDefaultSettings()
        {
            radioButtonOverwriteOriginal.Checked = true;
            radioButtonUseDirectory.Checked = false;
            textBoxOutputDirectory.Text = "";
            numUpDownNoOfPasses.Value = 3;
            numUpDownJpegQuality.Value = 100;
            checkBoxUseHighMemory.Checked = false;
            checkBoxRemoveImgMetaData.Checked = true;
        }
        private void LoadSettings()
        {
            // Check if ini file exists
            if (File.Exists(iniFilePath)) {
                try {
                    var iniFile = new INIClass(iniFilePath);
                    radioButtonOverwriteOriginal.Checked = iniFile.ReadValue("", "OverwriteOriginal") == "True";
                    radioButtonUseDirectory.Checked = iniFile.ReadValue("", "OverwriteOriginal") != "True";
                    textBoxOutputDirectory.Text = iniFile.ReadValue("", "OutputDirectory");
                    numUpDownNoOfPasses.Value = decimal.Parse(iniFile.ReadValue("", "NoOfPasses"));
                    numUpDownJpegQuality.Value = decimal.Parse(iniFile.ReadValue("", "JpegQuality"));
                    checkBoxUseHighMemory.Checked = iniFile.ReadValue("", "UseHighMemory") == "True";
                    checkBoxRemoveImgMetaData.Checked = iniFile.ReadValue("", "RemoveImgMetaData") == "True";
                    checkBoxResizeToMaxBounds.Checked = iniFile.ReadValue("", "ResizeToMaxBounds") == "True";
                    numericFieldMaxWidth.Value = decimal.Parse(iniFile.ReadValue("", "MaxResolutionWidth"));
                    numericFieldMaxHeight.Value = decimal.Parse(iniFile.ReadValue("", "MaxResolutionHeight"));
                }
                catch {
                    ResetDefaultSettings();
                }
            }
            // If not, then the application may be started for the first time
            else {
                ResetDefaultSettings();
                SaveSettings();
            }

        }
        private void SaveSettings()
        {
            try {
                string iniFileDirectory = Path.GetDirectoryName(iniFilePath);
                if (!Directory.Exists(iniFileDirectory)) { Directory.CreateDirectory(iniFileDirectory); }

                var iniFile = new INIClass(iniFilePath);
                iniFile.WriteValue("", "OverwriteOriginal", radioButtonOverwriteOriginal.Checked.ToString());
                iniFile.WriteValue("", "OutputDirectory", textBoxOutputDirectory.Text);
                iniFile.WriteValue("", "NoOfPasses", numUpDownNoOfPasses.Value.ToString());
                iniFile.WriteValue("", "JpegQuality", numUpDownJpegQuality.Value.ToString());
                iniFile.WriteValue("", "UseHighMemory", checkBoxUseHighMemory.Checked.ToString());
                iniFile.WriteValue("", "RemoveImgMetaData", checkBoxRemoveImgMetaData.Checked.ToString());
                iniFile.WriteValue("", "ResizeToMaxBounds", checkBoxResizeToMaxBounds.Checked.ToString());
                iniFile.WriteValue("", "MaxResolutionWidth", numericFieldMaxWidth.Value.ToString());
                iniFile.WriteValue("", "MaxResolutionHeight", numericFieldMaxHeight.Value.ToString());
            }
            catch (Exception ex) {
                toolStripBottomStatus.Text = "ERROR: " + ex.Message;
            }
        }
        #endregion

        #region "Compress Image Functions"
        private async Task InitDataGridFilesCompressImages()
        {
            // check validity of library files
            if (!(File.Exists(jpegOptimPath) && File.Exists(optiPngPath) && File.Exists(guetzlix86Path))) {
                MessageBox.Show("ERROR: Some program files cannot be found. Please reinstall application.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rowsNotProcessed = dataGridFiles.Rows.ToArray().Where(row => {
                var cellValue = (string)row.Cells["DataGridColumnStatus"].Value;
                return string.IsNullOrWhiteSpace(cellValue) || cellValue == "Cancelled" || cellValue == "Error";
            });

            if (rowsNotProcessed.IsEmpty()) { return; }

            // reset progress
            ToggleStartStopMenu();
            ProgressReset(rowsNotProcessed.Count());
            cancellationToken = new CancellationTokenSource();

            foreach(var row in rowsNotProcessed) {
                string newFileSizeText, status, remarks;

                try {
                    var workPath = row.Cells[0].ToolTipText;
                    var oldFileSize = FileHelper.GetFileSize(workPath);
                    uncompressedTotal += oldFileSize;

                    // process file
                    workPath = await CompressImage(workPath);

                    var newFileSize = FileHelper.GetFileSize(workPath);
                    var savedSize = Math.Abs(newFileSize - oldFileSize);
                    var percentSaved = Math.Round((double)savedSize / oldFileSize * 100);
                    compressedTotal += savedSize;

                    if (percentSaved > 0) {
                        newFileSizeText = StringHelper.ToReadableFileSize(newFileSize);
                        status = "Finished";
                        remarks = $"Saved {StringHelper.ToReadableFileSize(savedSize)} ({percentSaved}%)";
                    } else {
                        newFileSizeText = StringHelper.ToReadableFileSize(newFileSize);
                        status = "No changes";
                        remarks = "Image already optimized";
                    }

                    ProgressIncrement();
                    toolStripBottomStatus.Text = workPath;
                } catch (Exception ex) {
                    newFileSizeText = "";
                    status = "Error";
                    remarks = ex.Message;
                }

                row.Cells["DataGridColumnNewFileSize"].Value = newFileSizeText;
                row.Cells["DataGridColumnStatus"].Value = status;
                row.Cells["DataGridColumnRemarks"].Value = remarks;
            }

            // reset task bar
            ProgressFinish();
            ToggleStartStopMenu();
            toolStripBottomStatus.Text = string.Format("Saved a total of {0} ({1}%).",
                StringHelper.ToReadableFileSize(compressedTotal),
                compressedTotal > 0 ? Math.Round((double)compressedTotal / uncompressedTotal * 100) : 0);
        }

        private Task<string> CompressImage(string filename)
        {
            var settings = new Settings {
                JpegoptimExecPath = jpegOptimPath,
                GuetzliExecPath = guetzlix86Path,
                OptipngExecPath = optiPngPath,
                JpegQuality = (int)numUpDownJpegQuality.Value,
                JpegUseGuetzli = checkBoxUseHighMemory.Checked,
                MemoryLimit = memoryLimit,
                PngOptimPasses = (int)numUpDownNoOfPasses.Value,
                RemoveMetadata = checkBoxRemoveImgMetaData.Checked,
                OutputDirectory = radioButtonUseDirectory.Checked ? textBoxOutputDirectory.Text : "",
                ResizeToMaxBounds = checkBoxResizeToMaxBounds.Checked,
                MaxResolution = new Size((int)numericFieldMaxWidth.Value, (int)numericFieldMaxHeight.Value)
            };

            return CompressImageHelper.CompressImage(filename, settings, cancellationToken.Token);
        }
        #endregion

        #region "Form Functions"
        public void ProgressSet(int value)
        {
            toolStripBottomProgressBar.Value = value;
            TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
        }
        public void ProgressIncrement()
        {
            toolStripBottomProgressBar.Value++;
            TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
        }
        public void ProgressReset(int max = 0)
        {
            toolStripBottomProgressBar.Value = 0;
            toolStripBottomProgressBar.Maximum = max;
            TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.Normal);
            TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
        }
        public void ProgressFinish()
        {
            toolStripBottomProgressBar.Value = 0;
            TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.NoProgress);
            TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.Normal);
            TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
        }

        public Form1()
        {
            InitializeComponent();

            // events handlers
            dataGridFiles.DragDrop += DataGridFiles_DragDrop;
            dataGridFiles.DragEnter += DataGridFiles_DragEnter;
            dataGridFiles.KeyUp += DataGridFiles_KeyUp;
            dataGridFiles.SelectionChanged += DataGridFiles_SelectionChanged;
            dataGridFiles.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                if (currentProcessId != -1) {
                    if (MessageBox.Show("Compression is still running. Are you sure want to exit?", Text, MessageBoxButtons.YesNo) == DialogResult.No) {
                        e.Cancel = true;
                        return;
                    }

                    Process.GetProcessById(currentProcessId).Kill();
                }
            } catch { } // do nothing when process can't be closed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();

            if (Args != null) {
                ProcessParameters(null, Args);
                Args = null;
            }

            Text += Application.ProductVersion;

            new UpdateHelper("ICP", "http://earlpeter.com/programs/image-compressor", Application.ProductVersion).PerformUpdateCheck();
        }

        public delegate void ProcessParametersDelegate(object sender, string[] args);
        /// <summary>
        /// The form has loaded, and initialization will have been be done.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args">Array of arguments containing file names and folder names</param>
        public void ProcessParameters(object sender, string[] args)
        {
            if (!args.IsEmpty()) {
                Task.Factory.StartNew(() => Enumerate(args),
                    CancellationToken.None,
                    TaskCreationOptions.None,
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
        }
        #endregion

        #region "DataGridFiles Functions"
        private int listViewFirstDisplayed;
        private int listViewDisplayed;
        private int listViewLastVisible;
        private int listViewLastIndex;
        private void DataGridFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridFiles.SelectedCells.Count == 0) {
                dataGridFiles.ContextMenuStrip = ContextMenuEmptySelection;
            } else {
                dataGridFiles.ContextMenuStrip = ContextMenuFileSelected;
                List<DataGridViewRow> rows = new List<DataGridViewRow> { };
                foreach (DataGridViewCell MyCell in dataGridFiles.SelectedCells) {
                    rows.Add(MyCell.OwningRow);
                }

                //var rows = dataGridFiles.SelectedCells.Cast<DataGridViewCell>().Select(cell => cell.OwningRow).Distinct();

                rows = rows.Distinct().ToList();

                if (rows.Count == 1) {
                    RemoveItemToolStripMenuItem.Text = "Remove Row";
                    OpenContainingFolderToolStripMenuItem.Visible = true;
                } else {
                    RemoveItemToolStripMenuItem.Text = "Remove Rows";
                    OpenContainingFolderToolStripMenuItem.Visible = false;
                }
            }
        }
        private void DataGridFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                RemoveItemToolStripMenuItem_Click(null, null);
            } else if (e.KeyCode == Keys.Escape) {
                dataGridFiles.ClearSelection();
            }
        }
        private void DataGridFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void DataGridFiles_DragDrop(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy) {
                var source = (e.Data.GetData(DataFormats.FileDrop) as Array).Cast<string>();
                Enumerate(source);
            }
        }
        private void DataGridFilesAddRow(string filepath)
        {
            if (dataGridFiles.Rows.ToArray().Where(x => x.Cells[0].ToolTipText == filepath).Count() > 0) { return; }

            listViewFirstDisplayed = dataGridFiles.FirstDisplayedScrollingRowIndex;
            listViewDisplayed = dataGridFiles.DisplayedRowCount(true);
            listViewLastVisible = listViewFirstDisplayed + listViewDisplayed - 1;
            listViewLastIndex = dataGridFiles.RowCount - 1;

            var fileInfo = new FileInfo(filepath);
            var filename = Path.GetFileName(filepath);
            var dirname = Path.GetDirectoryName(filepath);

            var i = dataGridFiles.Rows.Add($"<{filename}> {dirname}", "", StringHelper.ToReadableFileSize(fileInfo.Length), "", fileInfo.CreationTime.ToShortTimeDateString(), "File not yet processed.");

            dataGridFiles.Rows[i].Cells[0].ToolTipText = filepath;

            if (listViewLastVisible == listViewLastIndex) { dataGridFiles.FirstDisplayedScrollingRowIndex = listViewFirstDisplayed + 1; }
        }

        #endregion

        #region "Settings Group"
        private void LabelNoOfPasses_Click(object sender, EventArgs e)
        {
            numUpDownNoOfPasses.Select();
        }
        private void ButtonSettingsOK_Click(object sender, EventArgs e)
        {
            try {
                if (radioButtonUseDirectory.Checked && (string.IsNullOrWhiteSpace(textBoxOutputDirectory.Text) || !Directory.Exists(textBoxOutputDirectory.Text))) {
                    throw new Exception("Invalid directory or directory does not exists.");
                }

                ToggleSettings();
                SaveSettings();
            } catch (Exception ex) {
                MessageBox.Show("WARNING: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSettingsCancel_Click(object sender, EventArgs e)
        {
            // TODO: Load init settings
            ToggleSettings();
        }

        private void ButtonBrowseDirectory_Click(object sender, EventArgs e)
        {
            if (dialogFolder.ShowDialog() == DialogResult.OK && Directory.Exists(dialogFolder.SelectedPath)) {
                textBoxOutputDirectory.Text = dialogFolder.SelectedPath;
            }
        }

        private void RadioButtonOverwriteOriginal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDifferentDir.Enabled = !radioButtonOverwriteOriginal.Checked;
        }

        private void CheckBoxResizeToMaxBounds_CheckedChanged(object sender, EventArgs e) {
            groupBoxResizeImage.Enabled = checkBoxResizeToMaxBounds.Checked;
        }
        #endregion

        #region "Top Menu"
        private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialogOpenFile.ShowDialog() == DialogResult.OK) {
                foreach (var filename in dialogOpenFile.FileNames) {
                    Enumerate(filename);
                }
            }
        }
        private void AddFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialogFolder.ShowDialog() == DialogResult.OK && Directory.Exists(dialogFolder.SelectedPath)) {
                cancellationToken = new CancellationTokenSource();
                Enumerate(dialogFolder.SelectedPath);
            }
        }
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            ToggleSettings();
        }
        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://earlpeter.com/programs/image-compressor");
        }
        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateHelper("ICP", "http://earlp.ru/image-compressor", Application.ProductVersion).PerformUpdateCheck(true);
        }
        private void SendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.earlpeter.com/contact/?subject=Image%20Compressor%20" + Application.ProductVersion);
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(Properties.Resources.AboutInfo, Application.ProductVersion), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region "Start/Stop Menu Bar"
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #pragma warning disable CS4014
            // Because this call is not awaited, execution of the current method continues before the call is completed
            InitDataGridFilesCompressImages();
            #pragma warning restore CS4014
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                cancellationToken.Cancel();
                // reset task bar
                ProgressFinish();
                ToggleStartStopMenu();
            } catch (ArgumentException) {
                // do nothing when process does not exists
            } catch (Exception ex) {
                ErrorHelper.ShowErrorMessage(ex, Text, errorLogPath);
            }
        }
        #endregion

        #region "Context Menu File"
        private void RemoveItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.SelectedRows.ToArray()) {
                dataGridFiles.Rows.Remove(row);
            }
        }

        private void OpenContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.SelectedRows.ToArray()) {
                ProcessHelper.RunProcessAsync("explorer.exe", "/select, " + row.Cells[0].ToolTipText);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.SelectedRows.ToArray()) {
                ProcessHelper.RunProcessAsync("explorer.exe", row.Cells[0].ToolTipText);
            }
        }

        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
            => dataGridFiles.Rows.Clear();
        #endregion
    }
}
