namespace picsorter {
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkFileTypeJpg = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkDeleteAfterMoving = new System.Windows.Forms.CheckBox();
            this.chkSearchSubDirectories = new System.Windows.Forms.CheckBox();
            this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 13);
            label1.TabIndex = 2;
            label1.Text = "Source Directory:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 13);
            label2.TabIndex = 6;
            label2.Text = "Destination:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 13);
            label3.TabIndex = 0;
            label3.Text = "Log:";
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.Location = new System.Drawing.Point(542, 8);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(44, 23);
            this.btnBrowseSource.TabIndex = 1;
            this.btnBrowseSource.Text = "...";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(107, 10);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(429, 20);
            this.txtSourceDirectory.TabIndex = 0;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.chkFileTypeJpg);
            this.grpOptions.Controls.Add(this.label4);
            this.grpOptions.Controls.Add(this.btnCancel);
            this.grpOptions.Controls.Add(this.btnStart);
            this.grpOptions.Controls.Add(this.chkDeleteAfterMoving);
            this.grpOptions.Controls.Add(this.chkSearchSubDirectories);
            this.grpOptions.Location = new System.Drawing.Point(12, 62);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(574, 134);
            this.grpOptions.TabIndex = 4;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // chkFileTypeJpg
            // 
            this.chkFileTypeJpg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFileTypeJpg.AutoSize = true;
            this.chkFileTypeJpg.Checked = true;
            this.chkFileTypeJpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileTypeJpg.Location = new System.Drawing.Point(522, 37);
            this.chkFileTypeJpg.Name = "chkFileTypeJpg";
            this.chkFileTypeJpg.Size = new System.Drawing.Size(46, 17);
            this.chkFileTypeJpg.TabIndex = 2;
            this.chkFileTypeJpg.Text = "JPG";
            this.chkFileTypeJpg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Types";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(412, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(493, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkDeleteAfterMoving
            // 
            this.chkDeleteAfterMoving.AutoSize = true;
            this.chkDeleteAfterMoving.Location = new System.Drawing.Point(7, 43);
            this.chkDeleteAfterMoving.Name = "chkDeleteAfterMoving";
            this.chkDeleteAfterMoving.Size = new System.Drawing.Size(200, 17);
            this.chkDeleteAfterMoving.TabIndex = 1;
            this.chkDeleteAfterMoving.Text = "Delete files from source after moving.";
            this.chkDeleteAfterMoving.UseVisualStyleBackColor = true;
            this.chkDeleteAfterMoving.CheckedChanged += new System.EventHandler(this.chkDeleteAfterMoving_CheckedChanged);
            // 
            // chkSearchSubDirectories
            // 
            this.chkSearchSubDirectories.AutoSize = true;
            this.chkSearchSubDirectories.Checked = true;
            this.chkSearchSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearchSubDirectories.Location = new System.Drawing.Point(7, 20);
            this.chkSearchSubDirectories.Name = "chkSearchSubDirectories";
            this.chkSearchSubDirectories.Size = new System.Drawing.Size(134, 17);
            this.chkSearchSubDirectories.TabIndex = 0;
            this.chkSearchSubDirectories.Text = "Search sub directories.";
            this.chkSearchSubDirectories.UseVisualStyleBackColor = true;
            // 
            // txtDestinationDirectory
            // 
            this.txtDestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationDirectory.Location = new System.Drawing.Point(107, 36);
            this.txtDestinationDirectory.Name = "txtDestinationDirectory";
            this.txtDestinationDirectory.Size = new System.Drawing.Size(429, 20);
            this.txtDestinationDirectory.TabIndex = 2;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDestination.Location = new System.Drawing.Point(542, 34);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(44, 23);
            this.btnBrowseDestination.TabIndex = 3;
            this.btnBrowseDestination.Text = "...";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 308);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(574, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // txtLog
            // 
            this.txtLog.AcceptsReturn = true;
            this.txtLog.AcceptsTab = true;
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 215);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(574, 87);
            this.txtLog.TabIndex = 5;
            this.txtLog.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(598, 343);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtDestinationDirectory);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.btnBrowseSource);
            this.MinimumSize = new System.Drawing.Size(304, 339);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pic Sorter";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtDestinationDirectory;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkDeleteAfterMoving;
        private System.Windows.Forms.CheckBox chkSearchSubDirectories;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkFileTypeJpg;
        private System.Windows.Forms.Label label4;
    }
}

