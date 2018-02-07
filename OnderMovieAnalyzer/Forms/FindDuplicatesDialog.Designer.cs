namespace OnderMovieAnalyzer.Forms
{
    partial class FindDuplicatesDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarInstall = new System.Windows.Forms.ProgressBar();
            this.labelCurrentStep = new System.Windows.Forms.Label();
            this.backgroundWorkerInstall = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarInstall, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentStep, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBarInstall
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBarInstall, 3);
            this.progressBarInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarInstall.Location = new System.Drawing.Point(17, 66);
            this.progressBarInstall.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarInstall.Name = "progressBarInstall";
            this.progressBarInstall.Size = new System.Drawing.Size(311, 36);
            this.progressBarInstall.TabIndex = 0;
            // 
            // labelCurrentStep
            // 
            this.labelCurrentStep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCurrentStep.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCurrentStep, 3);
            this.labelCurrentStep.Location = new System.Drawing.Point(17, 21);
            this.labelCurrentStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentStep.Name = "labelCurrentStep";
            this.labelCurrentStep.Size = new System.Drawing.Size(79, 13);
            this.labelCurrentStep.TabIndex = 1;
            this.labelCurrentStep.Text = "labelCurrentFile";
            // 
            // backgroundWorkerInstall
            // 
            this.backgroundWorkerInstall.WorkerReportsProgress = true;
            this.backgroundWorkerInstall.WorkerSupportsCancellation = true;
            this.backgroundWorkerInstall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInstall_DoWork);
            this.backgroundWorkerInstall.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerInstall_ProgressChanged);
            this.backgroundWorkerInstall.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInstall_RunWorkerCompleted);
            // 
            // FindDuplicatesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 120);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindDuplicatesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Finding duplicates...";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBarInstall;
        private System.Windows.Forms.Label labelCurrentStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInstall;
    }
}