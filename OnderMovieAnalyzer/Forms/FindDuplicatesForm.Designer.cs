namespace OnderMovieAnalyzer.Forms
{
    partial class FindDuplicatesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDuplicatesForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonDLDistance = new System.Windows.Forms.RadioButton();
            this.checkBoxFilesize = new System.Windows.Forms.CheckBox();
            this.checkBoxLanguage = new System.Windows.Forms.CheckBox();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.checkBoxQuality = new System.Windows.Forms.CheckBox();
            this.checkBoxPart = new System.Windows.Forms.CheckBox();
            this.checkBoxEpisode = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridDuplicates = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Episode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullSourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemRemoveFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDuplicates)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridDuplicates, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonDLDistance, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxFilesize, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxLanguage, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownDistance, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxYear, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxQuality, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPart, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxEpisode, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(731, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Checked = true;
            this.radioButtonName.Location = new System.Drawing.Point(3, 3);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(53, 17);
            this.radioButtonName.TabIndex = 1;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonDLDistance
            // 
            this.radioButtonDLDistance.AutoSize = true;
            this.radioButtonDLDistance.Location = new System.Drawing.Point(3, 26);
            this.radioButtonDLDistance.Name = "radioButtonDLDistance";
            this.radioButtonDLDistance.Size = new System.Drawing.Size(172, 17);
            this.radioButtonDLDistance.TabIndex = 2;
            this.radioButtonDLDistance.Text = "Damerau-Levenshtein distance";
            this.radioButtonDLDistance.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilesize
            // 
            this.checkBoxFilesize.AutoSize = true;
            this.checkBoxFilesize.Location = new System.Drawing.Point(322, 26);
            this.checkBoxFilesize.Name = "checkBoxFilesize";
            this.checkBoxFilesize.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFilesize.TabIndex = 5;
            this.checkBoxFilesize.Text = "Filesize";
            this.checkBoxFilesize.UseVisualStyleBackColor = true;
            // 
            // checkBoxLanguage
            // 
            this.checkBoxLanguage.AutoSize = true;
            this.checkBoxLanguage.Checked = true;
            this.checkBoxLanguage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLanguage.Location = new System.Drawing.Point(322, 3);
            this.checkBoxLanguage.Name = "checkBoxLanguage";
            this.checkBoxLanguage.Size = new System.Drawing.Size(103, 17);
            this.checkBoxLanguage.TabIndex = 4;
            this.checkBoxLanguage.Text = "Language (Dub)";
            this.checkBoxLanguage.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Location = new System.Drawing.Point(181, 26);
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownDistance.TabIndex = 3;
            this.numericUpDownDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(431, 3);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(91, 17);
            this.checkBoxYear.TabIndex = 6;
            this.checkBoxYear.Text = "Release Date";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuality
            // 
            this.checkBoxQuality.AutoSize = true;
            this.checkBoxQuality.Location = new System.Drawing.Point(431, 26);
            this.checkBoxQuality.Name = "checkBoxQuality";
            this.checkBoxQuality.Size = new System.Drawing.Size(58, 17);
            this.checkBoxQuality.TabIndex = 7;
            this.checkBoxQuality.Text = "Quality";
            this.checkBoxQuality.UseVisualStyleBackColor = true;
            // 
            // checkBoxPart
            // 
            this.checkBoxPart.AutoSize = true;
            this.checkBoxPart.Checked = true;
            this.checkBoxPart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPart.Location = new System.Drawing.Point(181, 3);
            this.checkBoxPart.Name = "checkBoxPart";
            this.checkBoxPart.Size = new System.Drawing.Size(45, 17);
            this.checkBoxPart.TabIndex = 8;
            this.checkBoxPart.Text = "Part";
            this.checkBoxPart.UseVisualStyleBackColor = true;
            // 
            // checkBoxEpisode
            // 
            this.checkBoxEpisode.AutoSize = true;
            this.checkBoxEpisode.Checked = true;
            this.checkBoxEpisode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEpisode.Location = new System.Drawing.Point(232, 3);
            this.checkBoxEpisode.Name = "checkBoxEpisode";
            this.checkBoxEpisode.Size = new System.Drawing.Size(64, 17);
            this.checkBoxEpisode.TabIndex = 9;
            this.checkBoxEpisode.Text = "Episode";
            this.checkBoxEpisode.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSave.Enabled = false;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.ImageIndex = 1;
            this.buttonSave.ImageList = this.imageList;
            this.buttonSave.Location = new System.Drawing.Point(515, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(235, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save Results";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "search.png");
            this.imageList.Images.SetKeyName(1, "archive.png");
            this.imageList.Images.SetKeyName(2, "trash-a.png");
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.ImageIndex = 0;
            this.buttonSearch.ImageList = this.imageList;
            this.buttonSearch.Location = new System.Drawing.Point(515, 99);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(235, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Start Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridDuplicates
            // 
            this.dataGridDuplicates.AllowUserToAddRows = false;
            this.dataGridDuplicates.AllowUserToDeleteRows = false;
            this.dataGridDuplicates.AllowUserToOrderColumns = true;
            this.dataGridDuplicates.AutoGenerateColumns = false;
            this.dataGridDuplicates.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridDuplicates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDuplicates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Part,
            this.Episode,
            this.languageDubDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.fullSourceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.lastModifiedDataGridViewTextBoxColumn,
            this.fullPathDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridDuplicates, 2);
            this.dataGridDuplicates.ContextMenuStrip = this.contextMenu;
            this.dataGridDuplicates.DataSource = this.bindingSource;
            this.dataGridDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDuplicates.Location = new System.Drawing.Point(13, 133);
            this.dataGridDuplicates.Name = "dataGridDuplicates";
            this.dataGridDuplicates.ReadOnly = true;
            this.dataGridDuplicates.RowHeadersVisible = false;
            this.dataGridDuplicates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDuplicates.ShowCellToolTips = false;
            this.dataGridDuplicates.ShowEditingIcon = false;
            this.dataGridDuplicates.Size = new System.Drawing.Size(737, 270);
            this.dataGridDuplicates.TabIndex = 13;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Part
            // 
            this.Part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Part.DataPropertyName = "Part";
            this.Part.HeaderText = "Part";
            this.Part.Name = "Part";
            this.Part.ReadOnly = true;
            this.Part.Width = 51;
            // 
            // Episode
            // 
            this.Episode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Episode.DataPropertyName = "Episode";
            this.Episode.HeaderText = "Episode";
            this.Episode.Name = "Episode";
            this.Episode.ReadOnly = true;
            this.Episode.Width = 70;
            // 
            // languageDubDataGridViewTextBoxColumn
            // 
            this.languageDubDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.languageDubDataGridViewTextBoxColumn.DataPropertyName = "LanguageDub";
            this.languageDubDataGridViewTextBoxColumn.FillWeight = 50F;
            this.languageDubDataGridViewTextBoxColumn.HeaderText = "Dub";
            this.languageDubDataGridViewTextBoxColumn.Name = "languageDubDataGridViewTextBoxColumn";
            this.languageDubDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDubDataGridViewTextBoxColumn.Width = 52;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Release";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 71;
            // 
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualityDataGridViewTextBoxColumn.Width = 64;
            // 
            // fullSourceDataGridViewTextBoxColumn
            // 
            this.fullSourceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fullSourceDataGridViewTextBoxColumn.DataPropertyName = "FullSource";
            this.fullSourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.fullSourceDataGridViewTextBoxColumn.Name = "fullSourceDataGridViewTextBoxColumn";
            this.fullSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullSourceDataGridViewTextBoxColumn.Width = 66;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 52;
            // 
            // lastModifiedDataGridViewTextBoxColumn
            // 
            this.lastModifiedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lastModifiedDataGridViewTextBoxColumn.DataPropertyName = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn.HeaderText = "Last Modified";
            this.lastModifiedDataGridViewTextBoxColumn.Name = "lastModifiedDataGridViewTextBoxColumn";
            this.lastModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastModifiedDataGridViewTextBoxColumn.Width = 95;
            // 
            // fullPathDataGridViewTextBoxColumn
            // 
            this.fullPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullPathDataGridViewTextBoxColumn.DataPropertyName = "FullPath";
            this.fullPathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.fullPathDataGridViewTextBoxColumn.Name = "fullPathDataGridViewTextBoxColumn";
            this.fullPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemRemoveFromList,
            this.itemDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(177, 48);
            // 
            // itemRemoveFromList
            // 
            this.itemRemoveFromList.Image = global::OnderMovieAnalyzer.Properties.Resources.close_circled;
            this.itemRemoveFromList.Name = "itemRemoveFromList";
            this.itemRemoveFromList.Size = new System.Drawing.Size(176, 22);
            this.itemRemoveFromList.Text = "Remove from list";
            this.itemRemoveFromList.Click += new System.EventHandler(this.itemRemoveFromList_Click);
            // 
            // itemDelete
            // 
            this.itemDelete.Image = global::OnderMovieAnalyzer.Properties.Resources.trash_a;
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(176, 22);
            this.itemDelete.Text = "Delete from system";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(OnderMovieAnalyzer.Objects.Movie);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "DuplicateDump";
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // FindDuplicatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FindDuplicatesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find Duplicates";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDuplicates)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonDLDistance;
        private System.Windows.Forms.CheckBox checkBoxFilesize;
        private System.Windows.Forms.CheckBox checkBoxLanguage;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox checkBoxQuality;
        private System.Windows.Forms.DataGridView dataGridDuplicates;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.CheckBox checkBoxPart;
        private System.Windows.Forms.CheckBox checkBoxEpisode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Episode;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullSourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem itemRemoveFromList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}