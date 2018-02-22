using EarlPeterG;
using EarlPeterG.IO;
using EarlPeterG.Win;
using EarlPeterG.Win.Forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCompressor
{
    public partial class Form1 : Form
    {
        public string[] Args { get; set; }

        private string iniFilePath = Path.Combine(Program.GetAppDataPath(), "settings.ini");
        private string errorLogPath = Path.Combine(Program.GetAppDataPath(), "error.log");
        private string jpegOptimPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\jpegoptim.exe");
        private string guetzlix86Path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\guetzli_windows_x86.exe");
        private string optiPngPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "lib\\optipng.exe");
        private decimal memoryLimit = Math.Round(new ComputerInfo().TotalPhysicalMemory * 0.75m / 1048576);
        private bool stopWorking = false;
        private int currentProcessId = -1;

        private object threadLock = new object { };

        #region "Local Functions"
        /// <summary>
        /// Checks if file extension is supported
        /// </summary>
        private bool IsValidFile(string file)
        {
            try {
                var extensions = new string[] { ".jpg", ".png" };

                var fileInfo = new FileInfo(file);

                return extensions.Contains(fileInfo.Extension.ToLower());
            }
            catch {
                return false;
            }
        }

        /// <summary>
        /// Enumerate files and folders inside a directory
        /// </summary>
        /// <param name="rootPath">The root directory where the program will start processing files</param>
        public void EnumerateAddFilesAndDir(string rootPath)
        {
            if (rootPath.EndsWith("\\")) rootPath = rootPath.Substring(0, rootPath.Length - 1);
            try {
                if (File.Exists(rootPath) && IsValidFile(rootPath)) {
                    DataGridFilesAddRow(rootPath);
                }
                else if (Directory.Exists(rootPath)) {
                    foreach (string file in Directory.GetFiles(rootPath)) {
                        if (stopWorking) return;
                        DataGridFilesAddRow(file);
                    }
                }
            }
            catch { }
        }

        private void ToggleSettings()
        {
            BoxSettings.Visible = !BoxSettings.Visible;
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
        }
        private void ToggleWaitCursor()
        {
            UseWaitCursor = !UseWaitCursor;
        }

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
                    radioButtonOverwriteOriginal.Checked = iniFile.IniReadValue("", "OverwriteOriginal") == "True";
                    radioButtonUseDirectory.Checked = iniFile.IniReadValue("", "OverwriteOriginal") != "True";
                    textBoxOutputDirectory.Text = iniFile.IniReadValue("", "OutputDirectory");
                    numUpDownNoOfPasses.Value = decimal.Parse(iniFile.IniReadValue("", "NoOfPasses"));
                    numUpDownJpegQuality.Value = decimal.Parse(iniFile.IniReadValue("", "JpegQuality"));
                    checkBoxUseHighMemory.Checked = iniFile.IniReadValue("", "UseHighMemory") == "True";
                    checkBoxRemoveImgMetaData.Checked = iniFile.IniReadValue("", "RemoveImgMetaData") == "True";
                }
                catch {
                    ResetDefaultSettings();
                }
            }
            // If not, then the application may be started for the first time
            // Suggest to create an entry in Windows Explorer's context menu
            else {
                ResetDefaultSettings();
                // Save default settings
                SaveSettings();
            }

        }
        private void SaveSettings()
        {
            try {
                string iniFileDirectory = Path.GetDirectoryName(iniFilePath);
                if (!Directory.Exists(iniFileDirectory)) Directory.CreateDirectory(iniFileDirectory);

                var iniFile = new INIClass(iniFilePath);
                iniFile.IniWriteValue("", "OverwriteOriginal", radioButtonOverwriteOriginal.Checked.ToString());
                iniFile.IniWriteValue("", "OverwriteOriginal", (!radioButtonUseDirectory.Checked).ToString());
                iniFile.IniWriteValue("", "OutputDirectory", textBoxOutputDirectory.Text);
                iniFile.IniWriteValue("", "NoOfPasses", numUpDownNoOfPasses.Value.ToString());
                iniFile.IniWriteValue("", "JpegQuality", numUpDownJpegQuality.Value.ToString());
                iniFile.IniWriteValue("", "UseHighMemory", checkBoxUseHighMemory.Checked.ToString());
                iniFile.IniWriteValue("", "RemoveImgMetaData", checkBoxRemoveImgMetaData.Checked.ToString());
            }
            catch (Exception ex) {
                toolStripBottomStatus.Text = "ERROR: " + ex.Message;
            }
        }
        #endregion

        #region "Compress Image Functions"
        private void CompressImage(string filename, int noOfPasses = 3, bool removeImgMetaData = false)
        {
            if (!File.Exists(filename)) throw new Exception("File does not exists.");

            var fileExtension = new FileInfo(filename).Extension.ToLower();

            /*
			 * libraries usage:
			 * guetzli --quality <quality> <input_filename> <output_filename>
			 * jpegoptim --dest="Alternate directory" --force --max=<quality> --strip-all <filenames>
			 * optiong <file> -o <levels> -out "<path>" -strip/-preserve
			 */
            string processPath = "",
                processArgs = "";
            if (fileExtension == ".jpg") {
                if (checkBoxUseHighMemory.Checked) {
                    processPath = guetzlix86Path;
                    processArgs = string.Format("--quality {0} --memlimit {1} \"{2}\" \"{3}\"", numUpDownJpegQuality.Value < 84 ? 84 : numUpDownJpegQuality.Value,
                        memoryLimit, filename,
                        radioButtonUseDirectory.Checked ? Path.Combine(textBoxOutputDirectory.Text, Path.GetFileName(filename)) : filename);
                }
                else {
                    processPath = jpegOptimPath;
                    processArgs = string.Format("\"{0}\"{2}{3}", filename, radioButtonOverwriteOriginal.Checked ? "" : "",
                        radioButtonUseDirectory.Checked ? " --dest=\"" + textBoxOutputDirectory.Text + "\"" : "",
                        removeImgMetaData ? " --strip-all" : "");
                }
            }
            else if (fileExtension == ".png") {
                processPath = optiPngPath;
                processArgs = string.Format("\"{0}\" -o {1}{2}{3}", filename, noOfPasses,
                    radioButtonUseDirectory.Checked ? " -dir \"" + textBoxOutputDirectory.Text + "\"" : "",
                    removeImgMetaData ? " -strip all" : "-preserve");
            }
            else {
                throw new Exception("Unknown file format.");
            }

            var process = ProcessHelper.RunProcessShellExecAsync(processPath, processArgs);
            currentProcessId = process.Id;
            process.WaitForExit();
            currentProcessId = -1;
        }
        private async void InitDataGridFilesCompressImages()
        {
            // check validity of library files
            if (!(File.Exists(jpegOptimPath) && File.Exists(optiPngPath) && File.Exists(guetzlix86Path))) {
                MessageBox.Show("ERROR: Some program files cannot be found. Please reinstall application.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (radioButtonUseDirectory.Checked && (string.IsNullOrWhiteSpace(textBoxOutputDirectory.Text) || !Directory.Exists(textBoxOutputDirectory.Text))) {
                MessageBox.Show("WARNING: Output directory not found. Please check your settings.", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ToggleSettings();
                return;
            }

            var rowsNotProcessed = dataGridFiles.Rows.ToArray().Where(x => string.IsNullOrWhiteSpace((string)x.Cells["DataGridColumnStatus"].Value) || (string)x.Cells["DataGridColumnStatus"].Value == "Cancelled");
            if (rowsNotProcessed.Count() == 0) return;
            stopWorking = false;

            ToggleStartStopMenu();

            toolStripBottomProgressBar.Maximum = rowsNotProcessed.Count();
            toolStripBottomProgressBar.Value = 0;
            TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.Normal);
            TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
            long uncompressedTotal = 0;
            long compressedTotal = 0;

            foreach (DataGridViewRow row in rowsNotProcessed) {
                dataGridFiles.CurrentCell = row.Cells[0];

                toolStripBottomStatus.Text = string.Format("{0}/{1} - {2}", toolStripBottomProgressBar.Value + 1, toolStripBottomProgressBar.Maximum, row.Cells[0].Value);
                if (stopWorking) {
                    row.Cells["DataGridColumnStatus"].Value = "Cancelled";
                    continue;
                }
                row.Cells["DataGridColumnStatus"].Value = "Working...";

                string workpath = row.Cells[0].ToolTipText;

                try {
                    var oldFileSize = FileHelper.GetFileSize(workpath);

                    // process file
                    await Task.Run(() => CompressImage(workpath, (int)numUpDownNoOfPasses.Value, checkBoxRemoveImgMetaData.Checked));

                    // refresh file info
                    if (radioButtonUseDirectory.Checked) {
                        var outPath = Path.Combine(textBoxOutputDirectory.Text, Path.GetFileName(workpath));
                        if (File.Exists(outPath)) workpath = outPath;
                    }
                    var newFileSize = FileHelper.GetFileSize(workpath);
                    var savedSize = oldFileSize - newFileSize;
                    uncompressedTotal += oldFileSize;
                    compressedTotal += savedSize;

                    if (Math.Round((double)(savedSize) / oldFileSize * 100) > 0) {
                        row.Cells["DataGridColumnNewFileSize"].Value = StringHelper.ConvertBytesToCommonSize(newFileSize);
                        row.Cells["DataGridColumnStatus"].Value = "Finished";
                        row.Cells["DataGridColumnRemarks"].Value = string.Format("Saved {0} ({1}%)", StringHelper.ConvertBytesToCommonSize(savedSize),
                            Math.Round((double)(savedSize) / oldFileSize * 100));
                    }
                    else {
                        row.Cells["DataGridColumnNewFileSize"].Value = StringHelper.ConvertBytesToCommonSize(newFileSize);
                        row.Cells["DataGridColumnStatus"].Value = "No changes";
                        row.Cells["DataGridColumnRemarks"].Value = "Image already optimized";
                    }
                }
                catch (Exception ex) {
                    row.Cells["DataGridColumnStatus"].Value = "Error";
                    row.Cells["DataGridColumnRemarks"].Value = ex.Message;
                }
                toolStripBottomProgressBar.Value++;
                TaskbarProgress.SetValue(Handle, toolStripBottomProgressBar.Value, toolStripBottomProgressBar.Maximum);
                Application.DoEvents();
            }

            TaskbarProgress.SetState(Handle, TaskbarProgress.TaskbarStates.NoProgress);
            toolStripBottomStatus.Text = string.Format("Saved a total of {0} ({1}%).",
                StringHelper.ConvertBytesToCommonSize(compressedTotal),
                compressedTotal > 0 ? Math.Round((double)(compressedTotal) / uncompressedTotal * 100) : 0);
            ToggleStartStopMenu();
        }
        #endregion

        #region "Form Functions"
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
            }
            catch { } // do nothing when process can't be closed
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
            Show();
            Activate();
            toolStripBottomStatus.Text = "";

            if (args != null && args.Length != 0) {
                if (args[0] == "-createreg") {
                    try {
                        // TODO: CreateContextMenuEntry();
                    }
                    catch (Exception ex) { ErrorHelper.ShowErrorMessage(ex, Text, errorLogPath); }
                }
                else {
                    for (int i = 0; i < args.Length; i++) {
                        if (File.Exists(args[i]) || Directory.Exists(args[i]))
                            EnumerateAddFilesAndDir(args[i]);
                    }
                }
            }
        }
        #endregion

        #region "DataGridFiles Functions"
        private int ListViewFirstDisplayed;
        private int ListViewDisplayed;
        private int ListViewLastVisible;
        private int ListViewLastIndex;
        private void DataGridFiles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridFiles.SelectedCells.Count == 0) {
                dataGridFiles.ContextMenuStrip = ContextMenuEmptySelection;
            }
            else {
                dataGridFiles.ContextMenuStrip = ContextMenuFileSelected;
                List<DataGridViewRow> MyRows = new List<DataGridViewRow> { };
                foreach (DataGridViewCell MyCell in dataGridFiles.SelectedCells) {
                    MyRows.Add(MyCell.OwningRow);
                }

                MyRows = MyRows.Distinct().ToList();

                if (MyRows.Count == 1) {
                    RemoveItemToolStripMenuItem.Text = "Remove Row";
                    OpenContainingFolderToolStripMenuItem.Visible = true;
                }
                else {
                    RemoveItemToolStripMenuItem.Text = "Remove Rows";
                    OpenContainingFolderToolStripMenuItem.Visible = false;
                }
            }
        }
        private void DataGridFiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                RemoveItemToolStripMenuItem_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape) {
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
                foreach (string MyFile in e.Data.GetData(DataFormats.FileDrop) as Array) {
                    if (stopWorking) return;
                    if (File.Exists(MyFile) && IsValidFile(MyFile)) EnumerateAddFilesAndDir(MyFile);
                    else if (Directory.Exists(MyFile)) EnumerateAddFilesAndDir(MyFile);
                }
            }
        }
        private void DataGridFilesAddRow(string filename)
        {
            if (dataGridFiles.Rows.ToArray().Where(x => x.Cells[0].ToolTipText == filename).Count() > 0) return;

            ListViewFirstDisplayed = dataGridFiles.FirstDisplayedScrollingRowIndex;
            ListViewDisplayed = dataGridFiles.DisplayedRowCount(true);
            ListViewLastVisible = (ListViewFirstDisplayed + ListViewDisplayed) - 1;
            ListViewLastIndex = dataGridFiles.RowCount - 1;

            var fileInfo = new FileInfo(filename);

            var i = dataGridFiles.Rows.Add("<" + Path.GetFileName(filename) + "> " + Path.GetDirectoryName(filename), "", StringHelper.ConvertBytesToCommonSize(fileInfo.Length), "", StringHelper.ConvertToShortDateTime(fileInfo.CreationTime), "File not yet processed.");

            dataGridFiles.Rows[i].Cells[0].ToolTipText = filename;

            if (ListViewLastVisible == ListViewLastIndex)
                dataGridFiles.FirstDisplayedScrollingRowIndex = ListViewFirstDisplayed + 1;
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
            }
            catch (Exception ex) {
                MessageBox.Show("WARNING: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSettingsCancel_Click(object sender, EventArgs e)
        {
            // TODO: Load init settings
            ToggleSettings();
        }

        private void buttonBrowseDirectory_Click(object sender, EventArgs e)
        {
            if (DialogFolder.ShowDialog() == DialogResult.OK && Directory.Exists(DialogFolder.SelectedPath)) {
                textBoxOutputDirectory.Text = DialogFolder.SelectedPath;
            }
        }

        private void radioButtonOverwriteOriginal_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDifferentDir.Enabled = !radioButtonOverwriteOriginal.Checked;
        }
        #endregion

        #region "Top Menu"
        private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogOpenFile.ShowDialog() == DialogResult.OK) {
                foreach (var filename in DialogOpenFile.FileNames) {
                    EnumerateAddFilesAndDir(filename);
                }
            }
        }
        private void AddFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogFolder.ShowDialog() == DialogResult.OK && Directory.Exists(DialogFolder.SelectedPath)) {
                EnumerateAddFilesAndDir(DialogFolder.SelectedPath);
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
            new UpdateHelper("ICP", "http://earlpeter.com/programs/image-compressor", Application.ProductVersion).PerformUpdateCheck(true);
        }
        private void SendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.earlpeter.com/contact-me/feedback/?ref=Image%20Compressor%20" + Application.ProductVersion);
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(Properties.Resources.AboutInfo, Application.ProductVersion), Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region "Start/Stop Menu Bar"
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitDataGridFilesCompressImages();
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                Process.GetProcessById(currentProcessId).Kill();
            }
            catch (ArgumentException) { } // do nothing when process does not exists
            catch (Exception ex) { ErrorHelper.ShowErrorMessage(ex, Text, errorLogPath); }
            stopWorking = true;
        }
        #endregion

        #region "Context Menu File Selected Functions"
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridFiles.SelectedRows.ToArray()) {
                ProcessHelper.RunProcessAsync("explorer.exe", row.Cells[0].ToolTipText);
            }
        }
        #endregion

        #region "Context Menu Empty Selection Functions"
        private void ClearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridFiles.Rows.Clear();
        }
        #endregion
    }
}