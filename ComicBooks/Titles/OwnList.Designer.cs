namespace Comics
{
    partial class OwnList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ownDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comicBookDetails1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBookDataSet = new Comics.ComicBookDataSet();
            this.comicBookDetails1TableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtSearchOwn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintWantList = new System.Windows.Forms.Button();
            this.txtTotalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDetails1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownDataGridViewCheckBoxColumn,
            this.wantDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.issueNumDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comicBookDetails1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // ownDataGridViewCheckBoxColumn
            // 
            this.ownDataGridViewCheckBoxColumn.DataPropertyName = "Own";
            this.ownDataGridViewCheckBoxColumn.HeaderText = "Own";
            this.ownDataGridViewCheckBoxColumn.Name = "ownDataGridViewCheckBoxColumn";
            // 
            // wantDataGridViewCheckBoxColumn
            // 
            this.wantDataGridViewCheckBoxColumn.DataPropertyName = "Want";
            this.wantDataGridViewCheckBoxColumn.HeaderText = "Want";
            this.wantDataGridViewCheckBoxColumn.Name = "wantDataGridViewCheckBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // issueNumDataGridViewTextBoxColumn
            // 
            this.issueNumDataGridViewTextBoxColumn.DataPropertyName = "IssueNum";
            this.issueNumDataGridViewTextBoxColumn.HeaderText = "IssueNum";
            this.issueNumDataGridViewTextBoxColumn.Name = "issueNumDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // comicBookDetails1BindingSource
            // 
            this.comicBookDetails1BindingSource.DataMember = "ComicBookDetails1";
            this.comicBookDetails1BindingSource.DataSource = this.comicBookDataSet;
            // 
            // comicBookDataSet
            // 
            this.comicBookDataSet.DataSetName = "ComicBookDataSet";
            this.comicBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comicBookDetails1TableAdapter
            // 
            this.comicBookDetails1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtShowAll);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.txtSearchOwn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(35, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(802, 54);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(595, 19);
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(136, 20);
            this.txtShowAll.TabIndex = 21;
            this.txtShowAll.Text = "Show All Titles";
            this.txtShowAll.UseVisualStyleBackColor = true;
            this.txtShowAll.Click += new System.EventHandler(this.txtShowAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(428, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtSearchOwn
            // 
            this.txtSearchOwn.Location = new System.Drawing.Point(69, 16);
            this.txtSearchOwn.Name = "txtSearchOwn";
            this.txtSearchOwn.Size = new System.Drawing.Size(298, 20);
            this.txtSearchOwn.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search";
            // 
            // btnPrintWantList
            // 
            this.btnPrintWantList.Location = new System.Drawing.Point(159, 382);
            this.btnPrintWantList.Name = "btnPrintWantList";
            this.btnPrintWantList.Size = new System.Drawing.Size(194, 27);
            this.btnPrintWantList.TabIndex = 36;
            this.btnPrintWantList.Text = "Print";
            this.btnPrintWantList.UseVisualStyleBackColor = true;
            this.btnPrintWantList.Click += new System.EventHandler(this.btnPrintOwnList_Click);
            // 
            // txtTotalNumber
            // 
            this.txtTotalNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalNumber.Location = new System.Drawing.Point(462, 278);
            this.txtTotalNumber.Name = "txtTotalNumber";
            this.txtTotalNumber.Size = new System.Drawing.Size(77, 20);
            this.txtTotalNumber.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total Number of Comics in Current View";
            // 
            // OwnList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 434);
            this.Controls.Add(this.txtTotalNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintWantList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OwnList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Own List";
            this.Load += new System.EventHandler(this.OwnList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ComicBookDataSet comicBookDataSet;
        private System.Windows.Forms.BindingSource comicBookDetails1BindingSource;
        private Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter comicBookDetails1TableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ownDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtShowAll;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.TextBox txtSearchOwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintWantList;
        private System.Windows.Forms.TextBox txtTotalNumber;
        private System.Windows.Forms.Label label1;
    }
}