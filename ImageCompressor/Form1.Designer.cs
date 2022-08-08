namespace ImageCompressor {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuBarTop = new System.Windows.Forms.MenuStrip();
            this.AddFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripBottomProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripBottomStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxResizeToMaxBounds = new System.Windows.Forms.CheckBox();
            this.groupBoxResizeImage = new System.Windows.Forms.GroupBox();
            this.numericFieldMaxHeight = new System.Windows.Forms.NumericUpDown();
            this.numericFieldMaxWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUseHighMemory = new System.Windows.Forms.CheckBox();
            this.numUpDownJpegQuality = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRemoveImgMetaData = new System.Windows.Forms.CheckBox();
            this.numUpDownNoOfPasses = new System.Windows.Forms.NumericUpDown();
            this.LabelNoOfPasses = new System.Windows.Forms.Label();
            this.radioButtonUseDirectory = new System.Windows.Forms.RadioButton();
            this.radioButtonOverwriteOriginal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSettingsCancel = new System.Windows.Forms.Button();
            this.ButtonSettingsOK = new System.Windows.Forms.Button();
            this.groupBoxDifferentDir = new System.Windows.Forms.GroupBox();
            this.buttonBrowseDirectory = new System.Windows.Forms.Button();
            this.textBoxOutputDirectory = new System.Windows.Forms.TextBox();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.DataGridColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnNewFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBarSecondary = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ContextMenuEmptySelection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuFileSelected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarTop.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.boxSettings.SuspendLayout();
            this.groupBoxResizeImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownJpegQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNoOfPasses)).BeginInit();
            this.groupBoxDifferentDir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.menuBarSecondary.SuspendLayout();
            this.ContextMenuEmptySelection.SuspendLayout();
            this.ContextMenuFileSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBarTop
            // 
            this.menuBarTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBarTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFilesToolStripMenuItem,
            this.AddFoldersToolStripMenuItem,
            this.SettingsMenuItem,
            this.HelpToolStripMenuItem});
            this.menuBarTop.Location = new System.Drawing.Point(0, 0);
            this.menuBarTop.Name = "menuBarTop";
            this.menuBarTop.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBarTop.Size = new System.Drawing.Size(1200, 31);
            this.menuBarTop.TabIndex = 34;
            // 
            // AddFilesToolStripMenuItem
            // 
            this.AddFilesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem";
            this.AddFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.AddFilesToolStripMenuItem.Text = "Add File(s) (Ctrl + O)";
            this.AddFilesToolStripMenuItem.Click += new System.EventHandler(this.AddFilesToolStripMenuItem_Click);
            // 
            // AddFoldersToolStripMenuItem
            // 
            this.AddFoldersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoldersToolStripMenuItem.Name = "AddFoldersToolStripMenuItem";
            this.AddFoldersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.AddFoldersToolStripMenuItem.Size = new System.Drawing.Size(186, 27);
            this.AddFoldersToolStripMenuItem.Text = "Add Folders (Ctrl + F)";
            this.AddFoldersToolStripMenuItem.ToolTipText = "NOTE: This does not include subfolders.";
            this.AddFoldersToolStripMenuItem.Click += new System.EventHandler(this.AddFoldersToolStripMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(85, 27);
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewHelpToolStripMenuItem,
            this.CheckForUpdatesToolStripMenuItem,
            this.SendFeedbackToolStripMenuItem,
            this.ToolStripSeparator2,
            this.AboutMenuItem});
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.HelpToolStripMenuItem.Text = "?";
            // 
            // ViewHelpToolStripMenuItem
            // 
            this.ViewHelpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem";
            this.ViewHelpToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.ViewHelpToolStripMenuItem.Text = "Visit Official Site";
            this.ViewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // SendFeedbackToolStripMenuItem
            // 
            this.SendFeedbackToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem";
            this.SendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(290, 28);
            this.SendFeedbackToolStripMenuItem.Text = "Send Feedback/Question";
            this.SendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.SendFeedbackToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(287, 6);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.BackColor = System.Drawing.Color.White;
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(290, 28);
            this.AboutMenuItem.Text = "About Image Compressor";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBottomProgressBar,
            this.toolStripBottomStatus,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 394);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(3, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1200, 29);
            this.statusBar.TabIndex = 35;
            // 
            // toolStripBottomProgressBar
            // 
            this.toolStripBottomProgressBar.Name = "toolStripBottomProgressBar";
            this.toolStripBottomProgressBar.Size = new System.Drawing.Size(133, 21);
            // 
            // toolStripBottomStatus
            // 
            this.toolStripBottomStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBottomStatus.Name = "toolStripBottomStatus";
            this.toolStripBottomStatus.Size = new System.Drawing.Size(250, 23);
            this.toolStripBottomStatus.Text = "Welcome to Image Compressor";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 23);
            // 
            // boxSettings
            // 
            this.boxSettings.Controls.Add(this.checkBoxResizeToMaxBounds);
            this.boxSettings.Controls.Add(this.groupBoxResizeImage);
            this.boxSettings.Controls.Add(this.checkBoxUseHighMemory);
            this.boxSettings.Controls.Add(this.numUpDownJpegQuality);
            this.boxSettings.Controls.Add(this.label2);
            this.boxSettings.Controls.Add(this.checkBoxRemoveImgMetaData);
            this.boxSettings.Controls.Add(this.numUpDownNoOfPasses);
            this.boxSettings.Controls.Add(this.LabelNoOfPasses);
            this.boxSettings.Controls.Add(this.radioButtonUseDirectory);
            this.boxSettings.Controls.Add(this.radioButtonOverwriteOriginal);
            this.boxSettings.Controls.Add(this.label1);
            this.boxSettings.Controls.Add(this.ButtonSettingsCancel);
            this.boxSettings.Controls.Add(this.ButtonSettingsOK);
            this.boxSettings.Controls.Add(this.groupBoxDifferentDir);
            this.boxSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSettings.Location = new System.Drawing.Point(392, 30);
            this.boxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.boxSettings.Name = "boxSettings";
            this.boxSettings.Padding = new System.Windows.Forms.Padding(4);
            this.boxSettings.Size = new System.Drawing.Size(595, 380);
            this.boxSettings.TabIndex = 0;
            this.boxSettings.TabStop = false;
            this.boxSettings.Visible = false;
            // 
            // checkBoxResizeToMaxBounds
            // 
            this.checkBoxResizeToMaxBounds.AutoSize = true;
            this.checkBoxResizeToMaxBounds.Location = new System.Drawing.Point(20, 258);
            this.checkBoxResizeToMaxBounds.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxResizeToMaxBounds.Name = "checkBoxResizeToMaxBounds";
            this.checkBoxResizeToMaxBounds.Size = new System.Drawing.Size(214, 27);
            this.checkBoxResizeToMaxBounds.TabIndex = 9;
            this.checkBoxResizeToMaxBounds.Text = "Resize image to &bounds";
            this.InfoToolTip.SetToolTip(this.checkBoxResizeToMaxBounds, "Resizes an image to the maximum possible size that will fit in a bounding box whi" +
        "le maintaining the aspect ratio.\r\nDefault: Unchecked");
            this.checkBoxResizeToMaxBounds.UseVisualStyleBackColor = true;
            this.checkBoxResizeToMaxBounds.CheckedChanged += new System.EventHandler(this.CheckBoxResizeToMaxBounds_CheckedChanged);
            // 
            // groupBoxResizeImage
            // 
            this.groupBoxResizeImage.Controls.Add(this.numericFieldMaxHeight);
            this.groupBoxResizeImage.Controls.Add(this.numericFieldMaxWidth);
            this.groupBoxResizeImage.Controls.Add(this.label3);
            this.groupBoxResizeImage.Enabled = false;
            this.groupBoxResizeImage.Location = new System.Drawing.Point(12, 263);
            this.groupBoxResizeImage.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxResizeImage.Name = "groupBoxResizeImage";
            this.groupBoxResizeImage.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxResizeImage.Size = new System.Drawing.Size(565, 66);
            this.groupBoxResizeImage.TabIndex = 0;
            this.groupBoxResizeImage.TabStop = false;
            // 
            // numericFieldMaxHeight
            // 
            this.numericFieldMaxHeight.Location = new System.Drawing.Point(155, 30);
            this.numericFieldMaxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericFieldMaxHeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericFieldMaxHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericFieldMaxHeight.Name = "numericFieldMaxHeight";
            this.numericFieldMaxHeight.Size = new System.Drawing.Size(120, 29);
            this.numericFieldMaxHeight.TabIndex = 11;
            this.numericFieldMaxHeight.ThousandsSeparator = true;
            this.InfoToolTip.SetToolTip(this.numericFieldMaxHeight, "Maximum Height");
            this.numericFieldMaxHeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericFieldMaxWidth
            // 
            this.numericFieldMaxWidth.Location = new System.Drawing.Point(8, 30);
            this.numericFieldMaxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericFieldMaxWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericFieldMaxWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericFieldMaxWidth.Name = "numericFieldMaxWidth";
            this.numericFieldMaxWidth.Size = new System.Drawing.Size(120, 29);
            this.numericFieldMaxWidth.TabIndex = 10;
            this.numericFieldMaxWidth.ThousandsSeparator = true;
            this.InfoToolTip.SetToolTip(this.numericFieldMaxWidth, "Maximum Width");
            this.numericFieldMaxWidth.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "x";
            // 
            // checkBoxUseHighMemory
            // 
            this.checkBoxUseHighMemory.AutoSize = true;
            this.checkBoxUseHighMemory.Location = new System.Drawing.Point(20, 196);
            this.checkBoxUseHighMemory.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUseHighMemory.Name = "checkBoxUseHighMemory";
            this.checkBoxUseHighMemory.Size = new System.Drawing.Size(521, 27);
            this.checkBoxUseHighMemory.TabIndex = 7;
            this.checkBoxUseHighMemory.Text = "Use &advanced JPEG compression (Warning: high memory usage)";
            this.InfoToolTip.SetToolTip(this.checkBoxUseHighMemory, resources.GetString("checkBoxUseHighMemory.ToolTip"));
            this.checkBoxUseHighMemory.UseVisualStyleBackColor = true;
            // 
            // numUpDownJpegQuality
            // 
            this.numUpDownJpegQuality.Location = new System.Drawing.Point(172, 162);
            this.numUpDownJpegQuality.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownJpegQuality.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numUpDownJpegQuality.Name = "numUpDownJpegQuality";
            this.numUpDownJpegQuality.Size = new System.Drawing.Size(57, 29);
            this.numUpDownJpegQuality.TabIndex = 6;
            this.numUpDownJpegQuality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jpeg Quality Level:";
            this.InfoToolTip.SetToolTip(this.label2, "Specify here the quality level of the output JPEG image. May range from 50 to 100" +
        ".\r\nDefault: 90");
            // 
            // checkBoxRemoveImgMetaData
            // 
            this.checkBoxRemoveImgMetaData.AutoSize = true;
            this.checkBoxRemoveImgMetaData.Checked = true;
            this.checkBoxRemoveImgMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveImgMetaData.Location = new System.Drawing.Point(20, 228);
            this.checkBoxRemoveImgMetaData.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRemoveImgMetaData.Name = "checkBoxRemoveImgMetaData";
            this.checkBoxRemoveImgMetaData.Size = new System.Drawing.Size(321, 27);
            this.checkBoxRemoveImgMetaData.TabIndex = 8;
            this.checkBoxRemoveImgMetaData.Text = "&Remove image metadata information.";
            this.InfoToolTip.SetToolTip(this.checkBoxRemoveImgMetaData, "Metadata includes information about the image, like how it was taken,\r\nthe GPS co" +
        "ordinates of the image, the date and time stamp, the camera\r\nsettings used, etc." +
        "\r\nDefault: Checked");
            this.checkBoxRemoveImgMetaData.UseVisualStyleBackColor = true;
            // 
            // numUpDownNoOfPasses
            // 
            this.numUpDownNoOfPasses.Location = new System.Drawing.Point(344, 123);
            this.numUpDownNoOfPasses.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownNoOfPasses.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownNoOfPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownNoOfPasses.Name = "numUpDownNoOfPasses";
            this.numUpDownNoOfPasses.Size = new System.Drawing.Size(57, 29);
            this.numUpDownNoOfPasses.TabIndex = 5;
            this.numUpDownNoOfPasses.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LabelNoOfPasses
            // 
            this.LabelNoOfPasses.AutoSize = true;
            this.LabelNoOfPasses.Location = new System.Drawing.Point(16, 126);
            this.LabelNoOfPasses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNoOfPasses.Name = "LabelNoOfPasses";
            this.LabelNoOfPasses.Size = new System.Drawing.Size(320, 23);
            this.LabelNoOfPasses.TabIndex = 0;
            this.LabelNoOfPasses.Text = "Number of Passes for PNG Optimization:";
            this.InfoToolTip.SetToolTip(this.LabelNoOfPasses, resources.GetString("LabelNoOfPasses.ToolTip"));
            this.LabelNoOfPasses.Click += new System.EventHandler(this.LabelNoOfPasses_Click);
            // 
            // radioButtonUseDirectory
            // 
            this.radioButtonUseDirectory.AutoSize = true;
            this.radioButtonUseDirectory.Location = new System.Drawing.Point(20, 54);
            this.radioButtonUseDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonUseDirectory.Name = "radioButtonUseDirectory";
            this.radioButtonUseDirectory.Size = new System.Drawing.Size(214, 27);
            this.radioButtonUseDirectory.TabIndex = 2;
            this.radioButtonUseDirectory.Text = "&Use a different directory";
            this.radioButtonUseDirectory.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverwriteOriginal
            // 
            this.radioButtonOverwriteOriginal.AutoSize = true;
            this.radioButtonOverwriteOriginal.Checked = true;
            this.radioButtonOverwriteOriginal.Location = new System.Drawing.Point(20, 28);
            this.radioButtonOverwriteOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOverwriteOriginal.Name = "radioButtonOverwriteOriginal";
            this.radioButtonOverwriteOriginal.Size = new System.Drawing.Size(200, 27);
            this.radioButtonOverwriteOriginal.TabIndex = 1;
            this.radioButtonOverwriteOriginal.TabStop = true;
            this.radioButtonOverwriteOriginal.Text = "O&verwrite original files";
            this.radioButtonOverwriteOriginal.UseVisualStyleBackColor = true;
            this.radioButtonOverwriteOriginal.CheckedChanged += new System.EventHandler(this.RadioButtonOverwriteOriginal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // ButtonSettingsCancel
            // 
            this.ButtonSettingsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettingsCancel.Location = new System.Drawing.Point(477, 338);
            this.ButtonSettingsCancel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettingsCancel.Name = "ButtonSettingsCancel";
            this.ButtonSettingsCancel.Size = new System.Drawing.Size(100, 28);
            this.ButtonSettingsCancel.TabIndex = 13;
            this.ButtonSettingsCancel.Text = "&Cancel";
            this.ButtonSettingsCancel.UseVisualStyleBackColor = true;
            this.ButtonSettingsCancel.Click += new System.EventHandler(this.ButtonSettingsCancel_Click);
            // 
            // ButtonSettingsOK
            // 
            this.ButtonSettingsOK.Location = new System.Drawing.Point(369, 337);
            this.ButtonSettingsOK.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSettingsOK.Name = "ButtonSettingsOK";
            this.ButtonSettingsOK.Size = new System.Drawing.Size(100, 28);
            this.ButtonSettingsOK.TabIndex = 12;
            this.ButtonSettingsOK.Text = "&OK";
            this.ButtonSettingsOK.UseVisualStyleBackColor = true;
            this.ButtonSettingsOK.Click += new System.EventHandler(this.ButtonSettingsOK_Click);
            // 
            // groupBoxDifferentDir
            // 
            this.groupBoxDifferentDir.Controls.Add(this.buttonBrowseDirectory);
            this.groupBoxDifferentDir.Controls.Add(this.textBoxOutputDirectory);
            this.groupBoxDifferentDir.Enabled = false;
            this.groupBoxDifferentDir.Location = new System.Drawing.Point(12, 57);
            this.groupBoxDifferentDir.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDifferentDir.Name = "groupBoxDifferentDir";
            this.groupBoxDifferentDir.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDifferentDir.Size = new System.Drawing.Size(565, 66);
            this.groupBoxDifferentDir.TabIndex = 0;
            this.groupBoxDifferentDir.TabStop = false;
            // 
            // buttonBrowseDirectory
            // 
            this.buttonBrowseDirectory.Location = new System.Drawing.Point(520, 23);
            this.buttonBrowseDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBrowseDirectory.Name = "buttonBrowseDirectory";
            this.buttonBrowseDirectory.Size = new System.Drawing.Size(39, 34);
            this.buttonBrowseDirectory.TabIndex = 4;
            this.buttonBrowseDirectory.Text = "&...";
            this.buttonBrowseDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseDirectory.Click += new System.EventHandler(this.ButtonBrowseDirectory_Click);
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(8, 26);
            this.textBoxOutputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(509, 29);
            this.textBoxOutputDirectory.TabIndex = 3;
            // 
            // InfoToolTip
            // 
            this.InfoToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InfoToolTip.ToolTipTitle = "Tip:";
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.AllowDrop = true;
            this.dataGridFiles.AllowUserToAddRows = false;
            this.dataGridFiles.BackgroundColor = System.Drawing.Color.White;
            this.dataGridFiles.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridColumnFileName,
            this.DataGridColumnStatus,
            this.DataGridColumnFileSize,
            this.DataGridColumnNewFileSize,
            this.DataGridColumnDateCreated,
            this.DataGridColumnRemarks});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFiles.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFiles.Location = new System.Drawing.Point(0, 63);
            this.dataGridFiles.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridFiles.RowHeadersWidth = 15;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiles.Size = new System.Drawing.Size(1200, 331);
            this.dataGridFiles.TabIndex = 39;
            this.dataGridFiles.SelectionChanged += new System.EventHandler(this.DataGridFiles_SelectionChanged);
            this.dataGridFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.DataGridFiles_DragDrop);
            this.dataGridFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.DataGridFiles_DragEnter);
            this.dataGridFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridFiles_KeyUp);
            // 
            // DataGridColumnFileName
            // 
            this.DataGridColumnFileName.HeaderText = "File Name";
            this.DataGridColumnFileName.MinimumWidth = 6;
            this.DataGridColumnFileName.Name = "DataGridColumnFileName";
            this.DataGridColumnFileName.ReadOnly = true;
            this.DataGridColumnFileName.Width = 180;
            // 
            // DataGridColumnStatus
            // 
            this.DataGridColumnStatus.HeaderText = "Status";
            this.DataGridColumnStatus.MinimumWidth = 6;
            this.DataGridColumnStatus.Name = "DataGridColumnStatus";
            this.DataGridColumnStatus.ReadOnly = true;
            this.DataGridColumnStatus.Width = 125;
            // 
            // DataGridColumnFileSize
            // 
            this.DataGridColumnFileSize.HeaderText = "Original File Size";
            this.DataGridColumnFileSize.MinimumWidth = 6;
            this.DataGridColumnFileSize.Name = "DataGridColumnFileSize";
            this.DataGridColumnFileSize.ReadOnly = true;
            this.DataGridColumnFileSize.Width = 165;
            // 
            // DataGridColumnNewFileSize
            // 
            this.DataGridColumnNewFileSize.HeaderText = "New File Size";
            this.DataGridColumnNewFileSize.MinimumWidth = 6;
            this.DataGridColumnNewFileSize.Name = "DataGridColumnNewFileSize";
            this.DataGridColumnNewFileSize.ReadOnly = true;
            this.DataGridColumnNewFileSize.Width = 140;
            // 
            // DataGridColumnDateCreated
            // 
            this.DataGridColumnDateCreated.HeaderText = "Date Created";
            this.DataGridColumnDateCreated.MinimumWidth = 6;
            this.DataGridColumnDateCreated.Name = "DataGridColumnDateCreated";
            this.DataGridColumnDateCreated.ReadOnly = true;
            this.DataGridColumnDateCreated.Width = 140;
            // 
            // DataGridColumnRemarks
            // 
            this.DataGridColumnRemarks.HeaderText = "Remarks";
            this.DataGridColumnRemarks.MinimumWidth = 6;
            this.DataGridColumnRemarks.Name = "DataGridColumnRemarks";
            this.DataGridColumnRemarks.ReadOnly = true;
            this.DataGridColumnRemarks.Width = 255;
            // 
            // menuBarSecondary
            // 
            this.menuBarSecondary.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuBarSecondary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuBarSecondary.Location = new System.Drawing.Point(0, 31);
            this.menuBarSecondary.Name = "menuBarSecondary";
            this.menuBarSecondary.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuBarSecondary.Size = new System.Drawing.Size(1200, 32);
            this.menuBarSecondary.TabIndex = 40;
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripMenuItem.Image")));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(100, 28);
            this.startToolStripMenuItem.Text = "START";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.stopToolStripMenuItem.Text = "STOP";
            this.stopToolStripMenuItem.Visible = false;
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // dialogOpenFile
            // 
            this.dialogOpenFile.Filter = "All Files|*.*|PNG images|*.png|JPG images|*.jpg";
            this.dialogOpenFile.Multiselect = true;
            // 
            // ContextMenuEmptySelection
            // 
            this.ContextMenuEmptySelection.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuEmptySelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAllToolStripMenuItem});
            this.ContextMenuEmptySelection.Name = "menu_list";
            this.ContextMenuEmptySelection.ShowImageMargin = false;
            this.ContextMenuEmptySelection.Size = new System.Drawing.Size(116, 32);
            // 
            // ClearAllToolStripMenuItem
            // 
            this.ClearAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem";
            this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.ClearAllToolStripMenuItem.Text = "Clear all";
            this.ClearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // ContextMenuFileSelected
            // 
            this.ContextMenuFileSelected.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuFileSelected.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuFileSelected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveItemToolStripMenuItem,
            this.openToolStripMenuItem,
            this.OpenContainingFolderToolStripMenuItem});
            this.ContextMenuFileSelected.Name = "menu_list";
            this.ContextMenuFileSelected.ShowImageMargin = false;
            this.ContextMenuFileSelected.Size = new System.Drawing.Size(233, 88);
            // 
            // RemoveItemToolStripMenuItem
            // 
            this.RemoveItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem";
            this.RemoveItemToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.RemoveItemToolStripMenuItem.Text = "Remove row";
            this.RemoveItemToolStripMenuItem.Click += new System.EventHandler(this.RemoveItemToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // OpenContainingFolderToolStripMenuItem
            // 
            this.OpenContainingFolderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenContainingFolderToolStripMenuItem.Name = "OpenContainingFolderToolStripMenuItem";
            this.OpenContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.OpenContainingFolderToolStripMenuItem.Text = "Open containing folder";
            this.OpenContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenContainingFolderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 423);
            this.Controls.Add(this.boxSettings);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBarSecondary);
            this.Controls.Add(this.menuBarTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1001, 363);
            this.Name = "Form1";
            this.Text = "Image Compressor ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBarTop.ResumeLayout(false);
            this.menuBarTop.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.boxSettings.ResumeLayout(false);
            this.boxSettings.PerformLayout();
            this.groupBoxResizeImage.ResumeLayout(false);
            this.groupBoxResizeImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFieldMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownJpegQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNoOfPasses)).EndInit();
            this.groupBoxDifferentDir.ResumeLayout(false);
            this.groupBoxDifferentDir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.menuBarSecondary.ResumeLayout(false);
            this.menuBarSecondary.PerformLayout();
            this.ContextMenuEmptySelection.ResumeLayout(false);
            this.ContextMenuFileSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.MenuStrip menuBarTop;
		internal System.Windows.Forms.ToolStripMenuItem AddFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddFoldersToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ViewHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem SendFeedbackToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		internal System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripProgressBar toolStripBottomProgressBar;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripBottomStatus;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		internal System.Windows.Forms.GroupBox boxSettings;
		private System.Windows.Forms.NumericUpDown numUpDownNoOfPasses;
		private System.Windows.Forms.Label LabelNoOfPasses;
		private System.Windows.Forms.RadioButton radioButtonUseDirectory;
		private System.Windows.Forms.RadioButton radioButtonOverwriteOriginal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonSettingsCancel;
		internal System.Windows.Forms.Button ButtonSettingsOK;
		private System.Windows.Forms.GroupBox groupBoxDifferentDir;
		internal System.Windows.Forms.Button buttonBrowseDirectory;
		private System.Windows.Forms.TextBox textBoxOutputDirectory;
		private System.Windows.Forms.CheckBox checkBoxRemoveImgMetaData;
		private System.Windows.Forms.ToolTip InfoToolTip;
		private System.Windows.Forms.DataGridView dataGridFiles;
		internal System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		internal System.Windows.Forms.OpenFileDialog dialogOpenFile;
		internal System.Windows.Forms.FolderBrowserDialog dialogFolder;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuEmptySelection;
		internal System.Windows.Forms.ToolStripMenuItem ClearAllToolStripMenuItem;
		internal System.Windows.Forms.ContextMenuStrip ContextMenuFileSelected;
		internal System.Windows.Forms.ToolStripMenuItem RemoveItemToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OpenContainingFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuBarSecondary;
		private System.Windows.Forms.NumericUpDown numUpDownJpegQuality;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxUseHighMemory;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnNewFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnRemarks;
        private System.Windows.Forms.CheckBox checkBoxResizeToMaxBounds;
        private System.Windows.Forms.GroupBox groupBoxResizeImage;
        private System.Windows.Forms.NumericUpDown numericFieldMaxHeight;
        private System.Windows.Forms.NumericUpDown numericFieldMaxWidth;
        private System.Windows.Forms.Label label3;
    }
}

