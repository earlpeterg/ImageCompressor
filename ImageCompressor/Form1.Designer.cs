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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.BoxSettings = new System.Windows.Forms.GroupBox();
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
            this.DialogOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ContextMenuEmptySelection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuFileSelected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarTop.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.BoxSettings.SuspendLayout();
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
            this.menuBarTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFilesToolStripMenuItem,
            this.AddFoldersToolStripMenuItem,
            this.SettingsMenuItem,
            this.HelpToolStripMenuItem});
            this.menuBarTop.Location = new System.Drawing.Point(0, 0);
            this.menuBarTop.Name = "menuBarTop";
            this.menuBarTop.Size = new System.Drawing.Size(900, 25);
            this.menuBarTop.TabIndex = 34;
            // 
            // AddFilesToolStripMenuItem
            // 
            this.AddFilesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem";
            this.AddFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.AddFilesToolStripMenuItem.Text = "Add File(s) (Ctrl + O)";
            this.AddFilesToolStripMenuItem.Click += new System.EventHandler(this.AddFilesToolStripMenuItem_Click);
            // 
            // AddFoldersToolStripMenuItem
            // 
            this.AddFoldersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoldersToolStripMenuItem.Name = "AddFoldersToolStripMenuItem";
            this.AddFoldersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.AddFoldersToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
            this.AddFoldersToolStripMenuItem.Text = "Add Folders (Ctrl + F)";
            this.AddFoldersToolStripMenuItem.ToolTipText = "NOTE: This does not include subfolders.";
            this.AddFoldersToolStripMenuItem.Click += new System.EventHandler(this.AddFoldersToolStripMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(66, 21);
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
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(26, 21);
            this.HelpToolStripMenuItem.Text = "?";
            // 
            // ViewHelpToolStripMenuItem
            // 
            this.ViewHelpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem";
            this.ViewHelpToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ViewHelpToolStripMenuItem.Text = "Visit Official Site";
            this.ViewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpToolStripMenuItem_Click);
            // 
            // CheckForUpdatesToolStripMenuItem
            // 
            this.CheckForUpdatesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
            this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.CheckForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // SendFeedbackToolStripMenuItem
            // 
            this.SendFeedbackToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem";
            this.SendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.SendFeedbackToolStripMenuItem.Text = "Send Feedback/Question";
            this.SendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.SendFeedbackToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.BackColor = System.Drawing.Color.White;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.BackColor = System.Drawing.Color.White;
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(227, 22);
            this.AboutMenuItem.Text = "About Image Compressor";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBottomProgressBar,
            this.toolStripBottomStatus,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 322);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(900, 22);
            this.statusBar.TabIndex = 35;
            // 
            // toolStripBottomProgressBar
            // 
            this.toolStripBottomProgressBar.Name = "toolStripBottomProgressBar";
            this.toolStripBottomProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripBottomStatus
            // 
            this.toolStripBottomStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBottomStatus.Name = "toolStripBottomStatus";
            this.toolStripBottomStatus.Size = new System.Drawing.Size(193, 17);
            this.toolStripBottomStatus.Text = "Welcome to Image Compressor";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // BoxSettings
            // 
            this.BoxSettings.Controls.Add(this.checkBoxUseHighMemory);
            this.BoxSettings.Controls.Add(this.numUpDownJpegQuality);
            this.BoxSettings.Controls.Add(this.label2);
            this.BoxSettings.Controls.Add(this.checkBoxRemoveImgMetaData);
            this.BoxSettings.Controls.Add(this.numUpDownNoOfPasses);
            this.BoxSettings.Controls.Add(this.LabelNoOfPasses);
            this.BoxSettings.Controls.Add(this.radioButtonUseDirectory);
            this.BoxSettings.Controls.Add(this.radioButtonOverwriteOriginal);
            this.BoxSettings.Controls.Add(this.label1);
            this.BoxSettings.Controls.Add(this.ButtonSettingsCancel);
            this.BoxSettings.Controls.Add(this.ButtonSettingsOK);
            this.BoxSettings.Controls.Add(this.groupBoxDifferentDir);
            this.BoxSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSettings.Location = new System.Drawing.Point(294, 25);
            this.BoxSettings.Name = "BoxSettings";
            this.BoxSettings.Size = new System.Drawing.Size(446, 256);
            this.BoxSettings.TabIndex = 37;
            this.BoxSettings.TabStop = false;
            this.BoxSettings.Visible = false;
            // 
            // checkBoxUseHighMemory
            // 
            this.checkBoxUseHighMemory.AutoSize = true;
            this.checkBoxUseHighMemory.Location = new System.Drawing.Point(15, 159);
            this.checkBoxUseHighMemory.Name = "checkBoxUseHighMemory";
            this.checkBoxUseHighMemory.Size = new System.Drawing.Size(403, 21);
            this.checkBoxUseHighMemory.TabIndex = 7;
            this.checkBoxUseHighMemory.Text = "Use &advanced JPEG compression (Warning: high memory usage)";
            this.InfoToolTip.SetToolTip(this.checkBoxUseHighMemory, resources.GetString("checkBoxUseHighMemory.ToolTip"));
            this.checkBoxUseHighMemory.UseVisualStyleBackColor = true;
            // 
            // numUpDownJpegQuality
            // 
            this.numUpDownJpegQuality.Location = new System.Drawing.Point(129, 131);
            this.numUpDownJpegQuality.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDownJpegQuality.Name = "numUpDownJpegQuality";
            this.numUpDownJpegQuality.Size = new System.Drawing.Size(43, 25);
            this.numUpDownJpegQuality.TabIndex = 6;
            this.InfoToolTip.SetToolTip(this.numUpDownJpegQuality, "Specify here the quality level of the output JPEG image. May range from 50 to 100" +
        ".");
            this.numUpDownJpegQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Jpeg Quality Level:";
            this.InfoToolTip.SetToolTip(this.label2, "Specify here the quality level of the output JPEG image. May range from 50 to 100" +
        ".\r\n");
            // 
            // checkBoxRemoveImgMetaData
            // 
            this.checkBoxRemoveImgMetaData.AutoSize = true;
            this.checkBoxRemoveImgMetaData.Checked = true;
            this.checkBoxRemoveImgMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRemoveImgMetaData.Location = new System.Drawing.Point(15, 185);
            this.checkBoxRemoveImgMetaData.Name = "checkBoxRemoveImgMetaData";
            this.checkBoxRemoveImgMetaData.Size = new System.Drawing.Size(247, 21);
            this.checkBoxRemoveImgMetaData.TabIndex = 8;
            this.checkBoxRemoveImgMetaData.Text = "&Remove image metadata information.";
            this.InfoToolTip.SetToolTip(this.checkBoxRemoveImgMetaData, "Metadata includes information about the image, like how it was taken,\r\nthe GPS co" +
        "ordinates of the image, the date and time stamp, the camera\r\nsettings used, etc." +
        "");
            this.checkBoxRemoveImgMetaData.UseVisualStyleBackColor = true;
            // 
            // numUpDownNoOfPasses
            // 
            this.numUpDownNoOfPasses.Location = new System.Drawing.Point(258, 100);
            this.numUpDownNoOfPasses.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numUpDownNoOfPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownNoOfPasses.Name = "numUpDownNoOfPasses";
            this.numUpDownNoOfPasses.Size = new System.Drawing.Size(43, 25);
            this.numUpDownNoOfPasses.TabIndex = 5;
            this.InfoToolTip.SetToolTip(this.numUpDownNoOfPasses, resources.GetString("numUpDownNoOfPasses.ToolTip"));
            this.numUpDownNoOfPasses.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // LabelNoOfPasses
            // 
            this.LabelNoOfPasses.AutoSize = true;
            this.LabelNoOfPasses.Location = new System.Drawing.Point(12, 102);
            this.LabelNoOfPasses.Name = "LabelNoOfPasses";
            this.LabelNoOfPasses.Size = new System.Drawing.Size(247, 17);
            this.LabelNoOfPasses.TabIndex = 0;
            this.LabelNoOfPasses.Text = "Number of Passes for PNG Optimization:";
            this.InfoToolTip.SetToolTip(this.LabelNoOfPasses, resources.GetString("LabelNoOfPasses.ToolTip"));
            this.LabelNoOfPasses.Click += new System.EventHandler(this.LabelNoOfPasses_Click);
            // 
            // radioButtonUseDirectory
            // 
            this.radioButtonUseDirectory.AutoSize = true;
            this.radioButtonUseDirectory.Location = new System.Drawing.Point(15, 44);
            this.radioButtonUseDirectory.Name = "radioButtonUseDirectory";
            this.radioButtonUseDirectory.Size = new System.Drawing.Size(168, 21);
            this.radioButtonUseDirectory.TabIndex = 2;
            this.radioButtonUseDirectory.Text = "&Use a different directory";
            this.radioButtonUseDirectory.UseVisualStyleBackColor = true;
            // 
            // radioButtonOverwriteOriginal
            // 
            this.radioButtonOverwriteOriginal.AutoSize = true;
            this.radioButtonOverwriteOriginal.Checked = true;
            this.radioButtonOverwriteOriginal.Location = new System.Drawing.Point(15, 23);
            this.radioButtonOverwriteOriginal.Name = "radioButtonOverwriteOriginal";
            this.radioButtonOverwriteOriginal.Size = new System.Drawing.Size(157, 21);
            this.radioButtonOverwriteOriginal.TabIndex = 1;
            this.radioButtonOverwriteOriginal.TabStop = true;
            this.radioButtonOverwriteOriginal.Text = "O&verwrite original files";
            this.radioButtonOverwriteOriginal.UseVisualStyleBackColor = true;
            this.radioButtonOverwriteOriginal.CheckedChanged += new System.EventHandler(this.radioButtonOverwriteOriginal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Settings";
            // 
            // ButtonSettingsCancel
            // 
            this.ButtonSettingsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettingsCancel.Location = new System.Drawing.Point(358, 217);
            this.ButtonSettingsCancel.Name = "ButtonSettingsCancel";
            this.ButtonSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonSettingsCancel.TabIndex = 27;
            this.ButtonSettingsCancel.Text = "&Cancel";
            this.ButtonSettingsCancel.UseVisualStyleBackColor = true;
            this.ButtonSettingsCancel.Click += new System.EventHandler(this.ButtonSettingsCancel_Click);
            // 
            // ButtonSettingsOK
            // 
            this.ButtonSettingsOK.Location = new System.Drawing.Point(268, 217);
            this.ButtonSettingsOK.Name = "ButtonSettingsOK";
            this.ButtonSettingsOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonSettingsOK.TabIndex = 14;
            this.ButtonSettingsOK.Text = "&OK";
            this.ButtonSettingsOK.UseVisualStyleBackColor = true;
            this.ButtonSettingsOK.Click += new System.EventHandler(this.ButtonSettingsOK_Click);
            // 
            // groupBoxDifferentDir
            // 
            this.groupBoxDifferentDir.Controls.Add(this.buttonBrowseDirectory);
            this.groupBoxDifferentDir.Controls.Add(this.textBoxOutputDirectory);
            this.groupBoxDifferentDir.Enabled = false;
            this.groupBoxDifferentDir.Location = new System.Drawing.Point(9, 46);
            this.groupBoxDifferentDir.Name = "groupBoxDifferentDir";
            this.groupBoxDifferentDir.Size = new System.Drawing.Size(424, 53);
            this.groupBoxDifferentDir.TabIndex = 32;
            this.groupBoxDifferentDir.TabStop = false;
            // 
            // buttonBrowseDirectory
            // 
            this.buttonBrowseDirectory.Location = new System.Drawing.Point(390, 19);
            this.buttonBrowseDirectory.Name = "buttonBrowseDirectory";
            this.buttonBrowseDirectory.Size = new System.Drawing.Size(29, 28);
            this.buttonBrowseDirectory.TabIndex = 4;
            this.buttonBrowseDirectory.Text = "&...";
            this.buttonBrowseDirectory.UseVisualStyleBackColor = true;
            this.buttonBrowseDirectory.Click += new System.EventHandler(this.buttonBrowseDirectory_Click);
            // 
            // textBoxOutputDirectory
            // 
            this.textBoxOutputDirectory.Location = new System.Drawing.Point(6, 21);
            this.textBoxOutputDirectory.Name = "textBoxOutputDirectory";
            this.textBoxOutputDirectory.Size = new System.Drawing.Size(383, 25);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridColumnFileName,
            this.DataGridColumnStatus,
            this.DataGridColumnFileSize,
            this.DataGridColumnNewFileSize,
            this.DataGridColumnDateCreated,
            this.DataGridColumnRemarks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFiles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFiles.Location = new System.Drawing.Point(0, 50);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridFiles.RowHeadersWidth = 15;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridFiles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFiles.Size = new System.Drawing.Size(900, 272);
            this.dataGridFiles.TabIndex = 39;
            // 
            // DataGridColumnFileName
            // 
            this.DataGridColumnFileName.HeaderText = "File Name";
            this.DataGridColumnFileName.Name = "DataGridColumnFileName";
            this.DataGridColumnFileName.ReadOnly = true;
            this.DataGridColumnFileName.Width = 180;
            // 
            // DataGridColumnStatus
            // 
            this.DataGridColumnStatus.HeaderText = "Status";
            this.DataGridColumnStatus.Name = "DataGridColumnStatus";
            this.DataGridColumnStatus.ReadOnly = true;
            // 
            // DataGridColumnFileSize
            // 
            this.DataGridColumnFileSize.HeaderText = "Original File Size";
            this.DataGridColumnFileSize.Name = "DataGridColumnFileSize";
            this.DataGridColumnFileSize.ReadOnly = true;
            this.DataGridColumnFileSize.Width = 140;
            // 
            // DataGridColumnNewFileSize
            // 
            this.DataGridColumnNewFileSize.HeaderText = "New File Size";
            this.DataGridColumnNewFileSize.Name = "DataGridColumnNewFileSize";
            this.DataGridColumnNewFileSize.ReadOnly = true;
            this.DataGridColumnNewFileSize.Width = 140;
            // 
            // DataGridColumnDateCreated
            // 
            this.DataGridColumnDateCreated.HeaderText = "Date Created";
            this.DataGridColumnDateCreated.Name = "DataGridColumnDateCreated";
            this.DataGridColumnDateCreated.ReadOnly = true;
            this.DataGridColumnDateCreated.Width = 140;
            // 
            // DataGridColumnRemarks
            // 
            this.DataGridColumnRemarks.HeaderText = "Remarks";
            this.DataGridColumnRemarks.Name = "DataGridColumnRemarks";
            this.DataGridColumnRemarks.ReadOnly = true;
            this.DataGridColumnRemarks.Width = 255;
            // 
            // menuBarSecondary
            // 
            this.menuBarSecondary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuBarSecondary.Location = new System.Drawing.Point(0, 25);
            this.menuBarSecondary.Name = "menuBarSecondary";
            this.menuBarSecondary.Size = new System.Drawing.Size(900, 25);
            this.menuBarSecondary.TabIndex = 40;
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripMenuItem.Image")));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.startToolStripMenuItem.Text = "START";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.stopToolStripMenuItem.Text = "STOP";
            this.stopToolStripMenuItem.Visible = false;
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // DialogOpenFile
            // 
            this.DialogOpenFile.Filter = "All Files|*.*|PNG images|*.png|JPG images|*.jpg";
            this.DialogOpenFile.Multiselect = true;
            // 
            // ContextMenuEmptySelection
            // 
            this.ContextMenuEmptySelection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearAllToolStripMenuItem});
            this.ContextMenuEmptySelection.Name = "menu_list";
            this.ContextMenuEmptySelection.ShowImageMargin = false;
            this.ContextMenuEmptySelection.Size = new System.Drawing.Size(98, 26);
            // 
            // ClearAllToolStripMenuItem
            // 
            this.ClearAllToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem";
            this.ClearAllToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.ClearAllToolStripMenuItem.Text = "Clear all";
            this.ClearAllToolStripMenuItem.Click += new System.EventHandler(this.ClearAllToolStripMenuItem_Click);
            // 
            // ContextMenuFileSelected
            // 
            this.ContextMenuFileSelected.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContextMenuFileSelected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveItemToolStripMenuItem,
            this.openToolStripMenuItem,
            this.OpenContainingFolderToolStripMenuItem});
            this.ContextMenuFileSelected.Name = "menu_list";
            this.ContextMenuFileSelected.ShowImageMargin = false;
            this.ContextMenuFileSelected.Size = new System.Drawing.Size(187, 92);
            // 
            // RemoveItemToolStripMenuItem
            // 
            this.RemoveItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemToolStripMenuItem.Name = "RemoveItemToolStripMenuItem";
            this.RemoveItemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.RemoveItemToolStripMenuItem.Text = "Remove row";
            this.RemoveItemToolStripMenuItem.Click += new System.EventHandler(this.RemoveItemToolStripMenuItem_Click);
            // 
            // OpenContainingFolderToolStripMenuItem
            // 
            this.OpenContainingFolderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenContainingFolderToolStripMenuItem.Name = "OpenContainingFolderToolStripMenuItem";
            this.OpenContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.OpenContainingFolderToolStripMenuItem.Text = "Open containing folder";
            this.OpenContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenContainingFolderToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 344);
            this.Controls.Add(this.BoxSettings);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBarSecondary);
            this.Controls.Add(this.menuBarTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(757, 308);
            this.Name = "Form1";
            this.Text = "Image Compressor ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBarTop.ResumeLayout(false);
            this.menuBarTop.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.BoxSettings.ResumeLayout(false);
            this.BoxSettings.PerformLayout();
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
		internal System.Windows.Forms.GroupBox BoxSettings;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnFileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnFileSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnNewFileSize;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnDateCreated;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataGridColumnRemarks;
		internal System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		internal System.Windows.Forms.OpenFileDialog DialogOpenFile;
		internal System.Windows.Forms.FolderBrowserDialog DialogFolder;
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
    }
}

