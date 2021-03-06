﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace picsorter {
    public partial class Form1 : Form {

        #region Members

        BackgroundWorker bw = null;

        #endregion


        #region Constructor

        public Form1() {
            InitializeComponent();
            ClearLog();
            Log("Application Started.");
        }

        #endregion


        #region Directory Browsing

        private void btnBrowseSource_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = "Select source folder folder to search for images.";
            DialogResult dr = folderBrowserDialog1.ShowDialog(this);
            if (dr == System.Windows.Forms.DialogResult.OK) {
                txtSourceDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = "Select the root destination folder for the images.";
            DialogResult dr = folderBrowserDialog1.ShowDialog(this);
            if (dr == System.Windows.Forms.DialogResult.OK) {
                txtDestinationDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        #endregion


        #region Options

        private void chkDeleteAfterMoving_CheckedChanged(object sender, EventArgs e) {
            if (chkDeleteAfterMoving.Checked) {
                DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete files from source after moving?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == System.Windows.Forms.DialogResult.No) {
                    chkDeleteAfterMoving.Checked = false;
                }
            }
        }

        #endregion


        #region Processing

        private void btnStart_Click(object sender, EventArgs e) {
            string errorMessage = string.Empty;
            if (!ValidateInput(ref errorMessage)) {
                MessageBox.Show(this, "Could not start.\n" + errorMessage, "Check Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EnableUi(false);

            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            EnableUi(true);
        }


        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            Workerstatus w = e.UserState as Workerstatus;
            if (w != null) {
                progressBar1.Minimum = w.Minimum;
                progressBar1.Maximum = w.Maximum;
                progressBar1.Value = w.Value;
            }
        }

        public static IEnumerable<string> GetFiles(string path,
                       string searchPatternExpression = "",
                       SearchOption searchOption = SearchOption.TopDirectoryOnly) {
            Regex reSearchPattern = new Regex(searchPatternExpression);
            return Directory.EnumerateFiles(path, "*", searchOption)
                            .Where(file =>
                                     reSearchPattern.IsMatch(Path.GetExtension(file).ToLower()));
        }


        void bw_DoWork(object sender, DoWorkEventArgs e) {
            SearchOption option;
            if (chkSearchSubDirectories.Checked) {
                option = SearchOption.AllDirectories;
            }
            else {
                option = SearchOption.TopDirectoryOnly;
            }

            StringBuilder sbTypes = new StringBuilder();
            //JPG
            if (chkFileTypeJpg.Checked) {
                if (sbTypes.Length > 0)
                    sbTypes.Append("|");
                sbTypes.Append(@"\.jpg");
            }
            //MP4
            if (chkFileTypeMP4.Checked) {
                if (sbTypes.Length > 0)
                    sbTypes.Append("|");
                sbTypes.Append(@"\.mp4");
            }

            if (sbTypes.Length == 0) {
                Log("Nothing selected to scan.");
            }
            else {
                Log("Scanning source directory...");
                //var allFiles = Directory.EnumerateFiles(txtSourceDirectory.Text, sbTypes.ToString(), option).ToList();
                var allFiles = GetFiles(txtSourceDirectory.Text, sbTypes.ToString(), option).ToList();
                int totalFiles = allFiles.Count();
                int counter = 0;
                int counterCreated = 0;
                int counterCopied = 0;
                int counterDeleted = 0;
                int counterWarnings = 0;
                Log(string.Format("Found {0} source files.", totalFiles));


                foreach (var fileName in allFiles) {
                    counter++;
                    bw.ReportProgress(0, new Workerstatus() { Minimum = 0, Maximum = totalFiles, Value = counter });

                    FileInfo fi = new FileInfo(fileName);

                    DateTime modTime = fi.LastWriteTime;

                    string year = modTime.Year.ToString();
                    string month = modTime.Month.ToString().PadLeft(2, '0');
                    string date = modTime.Day.ToString().PadLeft(2, '0');

                    string subPath = string.Format("{0}{1}\\{0}-{1}-{2}", year, month, date);
                    string destination = System.IO.Path.Combine(txtDestinationDirectory.Text, subPath);

                    if(!Directory.Exists(destination)) {
                        Directory.CreateDirectory(destination);
                        counterCreated++;
                    }

                    string fileDestination = System.IO.Path.Combine(destination, fi.Name);
                    if (!File.Exists(fileDestination)) {
                        Status(string.Format("Copying {0} to {1}", fileName, subPath));
                        fi.CopyTo(fileDestination);
                        counterCopied++;
                        if (chkDeleteAfterMoving.Checked) {
                            fi.Delete();
                            counterDeleted++;
                        }
                    }
                    else {
                        Log("Warning: When copying " + fileName + ", " + fileDestination + " already exists.");
                        counterWarnings++;
                    }

                    if (bw.CancellationPending) {
                        Log("Cancelled.");
                        Status("Cancelled.");
                        return;
                    }
                }

                Log(string.Format("Processed: {0}", counter));
                Log(string.Format("Directories Created: {0}", counterCreated));
                Log(string.Format("Copied: {0}", counterCopied));
                Log(string.Format("Deleted: {0}", counterDeleted));
                Log(string.Format("Warnings: {0}", counterWarnings));
            }

            Log("Completed.");
            Status("Completed.");
        }

        #endregion


        #region UI/Validation

        private void EnableUi(bool e) {
            if (e) {
                this.Cursor = Cursors.Default;
            }
            else {
                this.Cursor = Cursors.WaitCursor;
            }

            txtDestinationDirectory.Enabled = e;
            btnBrowseDestination.Enabled = e;
            txtSourceDirectory.Enabled = e;
            btnBrowseSource.Enabled = e;

            chkSearchSubDirectories.Enabled = e;
            chkDeleteAfterMoving.Enabled = e;

            btnCancel.Enabled = !e;
            btnStart.Enabled = e;
        }


        private bool ValidateInput(ref string errorMessage) {
            if (string.IsNullOrWhiteSpace(txtSourceDirectory.Text) || !Directory.Exists(txtSourceDirectory.Text)) {
                errorMessage = "Source directory not found.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDestinationDirectory.Text) || !Directory.Exists(txtDestinationDirectory.Text)) {
                errorMessage = "Destination directory not found.";
                return false;
            }
            if (txtDestinationDirectory.Text.Equals(txtSourceDirectory.Text, StringComparison.CurrentCultureIgnoreCase)) {
                errorMessage = "Source and Destination cannot be the same";
                return false;
            }
            return true;
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to cancel?", "Cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.Yes && bw != null) {
                bw.CancelAsync();
            }
        }

        #endregion


        #region Logging

        private void ClearLog() {
            txtLog.Text = string.Empty;
        }


        private void Log(string p) {
            if (InvokeRequired) {
                Invoke((MethodInvoker)delegate {
                    Log(p);
                });
            }
            else {
                if (p == null) {
                    txtLog.Text = string.Empty;
                }
                else {
                    if (txtLog.Text.Length > 0)
                        txtLog.Text += Environment.NewLine;
                    txtLog.Text += System.DateTime.Now.ToShortTimeString() + " >> " + p;
                    txtLog.SelectionStart = txtLog.Text.Length;
                    txtLog.ScrollToCaret();
                }
            }
        }


        private void Status(string p) {
            if (InvokeRequired) {
                Invoke((MethodInvoker)delegate {
                    Status(p);
                });
            }
            else {
                lblStatus.Text = p;
            }
        }

        #endregion

    }

    internal class Workerstatus {
        internal int Minimum;
        internal int Maximum;
        internal int Value;
    }
}
