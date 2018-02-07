namespace OnderMovieAnalyzer.Forms
{
    partial class ExportDuplicatesDialog
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
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelSource = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.labelScript = new System.Windows.Forms.Label();
            this.radioCopyScript = new System.Windows.Forms.RadioButton();
            this.radioDeleteScript = new System.Windows.Forms.RadioButton();
            this.backgroundWorkerInstall = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.buttonExport, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelSource, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPriority, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelScript, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioCopyScript, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.radioDeleteScript, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonExport, 3);
            this.buttonExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.ImageIndex = 1;
            this.buttonExport.Location = new System.Drawing.Point(18, 119);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(306, 23);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelSource
            // 
            this.labelSource.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(18, 22);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(94, 13);
            this.labelSource.TabIndex = 17;
            this.labelSource.Text = "FileSource Priority:";
            // 
            // comboBoxPriority
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxPriority, 2);
            this.comboBoxPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(122, 19);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(202, 21);
            this.comboBoxPriority.TabIndex = 1;
            // 
            // labelScript
            // 
            this.labelScript.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScript.AutoSize = true;
            this.labelScript.Location = new System.Drawing.Point(18, 82);
            this.labelScript.Name = "labelScript";
            this.labelScript.Size = new System.Drawing.Size(61, 13);
            this.labelScript.TabIndex = 16;
            this.labelScript.Text = "ScriptType:";
            // 
            // radioCopyScript
            // 
            this.radioCopyScript.AutoSize = true;
            this.radioCopyScript.Checked = true;
            this.radioCopyScript.Location = new System.Drawing.Point(122, 79);
            this.radioCopyScript.Name = "radioCopyScript";
            this.radioCopyScript.Size = new System.Drawing.Size(79, 17);
            this.radioCopyScript.TabIndex = 4;
            this.radioCopyScript.TabStop = true;
            this.radioCopyScript.Text = "Copy Script";
            this.radioCopyScript.UseVisualStyleBackColor = true;
            // 
            // radioDeleteScript
            // 
            this.radioDeleteScript.AutoSize = true;
            this.radioDeleteScript.Location = new System.Drawing.Point(226, 79);
            this.radioDeleteScript.Name = "radioDeleteScript";
            this.radioDeleteScript.Size = new System.Drawing.Size(86, 17);
            this.radioDeleteScript.TabIndex = 5;
            this.radioDeleteScript.Text = "Delete Script";
            this.radioDeleteScript.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "OnderMovieCopyScript";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // ExportDuplicatesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 169);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExportDuplicatesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Export Duplicates";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInstall;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.RadioButton radioCopyScript;
        private System.Windows.Forms.RadioButton radioDeleteScript;
        private System.Windows.Forms.Label labelScript;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}