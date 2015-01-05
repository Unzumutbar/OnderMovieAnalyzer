namespace OnderMovieAnalyzer.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonViewDatabase = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonGetDuplicates = new System.Windows.Forms.Button();
            this.buttonSearchDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.buttonViewDatabase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGetDuplicates, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchDirectory, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonViewDatabase
            // 
            this.buttonViewDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonViewDatabase.ImageIndex = 1;
            this.buttonViewDatabase.ImageList = this.imageList;
            this.buttonViewDatabase.Location = new System.Drawing.Point(13, 13);
            this.buttonViewDatabase.Name = "buttonViewDatabase";
            this.buttonViewDatabase.Size = new System.Drawing.Size(182, 54);
            this.buttonViewDatabase.TabIndex = 3;
            this.buttonViewDatabase.Text = "View database";
            this.buttonViewDatabase.UseVisualStyleBackColor = true;
            this.buttonViewDatabase.Click += new System.EventHandler(this.buttonViewDatabase_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "flask.png");
            this.imageList.Images.SetKeyName(1, "android-storage.png");
            this.imageList.Images.SetKeyName(2, "ios7-film.png");
            // 
            // buttonGetDuplicates
            // 
            this.buttonGetDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGetDuplicates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetDuplicates.ImageKey = "flask.png";
            this.buttonGetDuplicates.ImageList = this.imageList;
            this.buttonGetDuplicates.Location = new System.Drawing.Point(13, 143);
            this.buttonGetDuplicates.Name = "buttonGetDuplicates";
            this.buttonGetDuplicates.Size = new System.Drawing.Size(182, 54);
            this.buttonGetDuplicates.TabIndex = 2;
            this.buttonGetDuplicates.Text = "Find duplicates";
            this.buttonGetDuplicates.UseVisualStyleBackColor = true;
            this.buttonGetDuplicates.Click += new System.EventHandler(this.buttonGetDuplicates_Click);
            // 
            // buttonSearchDirectory
            // 
            this.buttonSearchDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchDirectory.ImageIndex = 2;
            this.buttonSearchDirectory.ImageList = this.imageList;
            this.buttonSearchDirectory.Location = new System.Drawing.Point(13, 78);
            this.buttonSearchDirectory.Name = "buttonSearchDirectory";
            this.buttonSearchDirectory.Size = new System.Drawing.Size(182, 54);
            this.buttonSearchDirectory.TabIndex = 4;
            this.buttonSearchDirectory.Text = "Analyze movies";
            this.buttonSearchDirectory.UseVisualStyleBackColor = true;
            this.buttonSearchDirectory.Click += new System.EventHandler(this.buttonSearchDirectory_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Onder Analyzer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGetDuplicates;
        private System.Windows.Forms.Button buttonViewDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button buttonSearchDirectory;
    }
}