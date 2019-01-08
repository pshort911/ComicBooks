namespace Comics
{
    partial class ComicsOwned
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
            this.dgNumOwned = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfOwnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comicBookNumOwnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBookDataSet = new Comics.ComicBookDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtShowAll = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtSearchOwn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrintWantList = new System.Windows.Forms.Button();
            this.txtTotalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comicBookNumOwnedTableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookNumOwnedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgNumOwned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookNumOwnedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgNumOwned
            // 
            this.dgNumOwned.AllowUserToAddRows = false;
            this.dgNumOwned.AllowUserToDeleteRows = false;
            this.dgNumOwned.AllowUserToOrderColumns = true;
            this.dgNumOwned.AllowUserToResizeColumns = false;
            this.dgNumOwned.AllowUserToResizeRows = false;
            this.dgNumOwned.AutoGenerateColumns = false;
            this.dgNumOwned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNumOwned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.countOfOwnedDataGridViewTextBoxColumn});
            this.dgNumOwned.DataSource = this.comicBookNumOwnedBindingSource;
            this.dgNumOwned.Location = new System.Drawing.Point(13, 13);
            this.dgNumOwned.Name = "dgNumOwned";
            this.dgNumOwned.ReadOnly = true;
            this.dgNumOwned.Size = new System.Drawing.Size(551, 248);
            this.dgNumOwned.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countOfOwnedDataGridViewTextBoxColumn
            // 
            this.countOfOwnedDataGridViewTextBoxColumn.DataPropertyName = "Count of Owned";
            this.countOfOwnedDataGridViewTextBoxColumn.HeaderText = "Count of Owned";
            this.countOfOwnedDataGridViewTextBoxColumn.Name = "countOfOwnedDataGridViewTextBoxColumn";
            this.countOfOwnedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comicBookNumOwnedBindingSource
            // 
            this.comicBookNumOwnedBindingSource.DataMember = "ComicBookNumOwned";
            this.comicBookNumOwnedBindingSource.DataSource = this.comicBookDataSet;
            // 
            // comicBookDataSet
            // 
            this.comicBookDataSet.DataSetName = "ComicBookDataSet";
            this.comicBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 27);
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
            this.groupBox3.Location = new System.Drawing.Point(15, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 61);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(385, 22);
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(136, 20);
            this.txtShowAll.TabIndex = 21;
            this.txtShowAll.Text = "Show All Titles";
            this.txtShowAll.UseVisualStyleBackColor = true;
            this.txtShowAll.Click += new System.EventHandler(this.txtShowAll_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(243, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtSearchOwn
            // 
            this.txtSearchOwn.Location = new System.Drawing.Point(60, 23);
            this.txtSearchOwn.Name = "txtSearchOwn";
            this.txtSearchOwn.Size = new System.Drawing.Size(150, 20);
            this.txtSearchOwn.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search";
            // 
            // btnPrintWantList
            // 
            this.btnPrintWantList.Location = new System.Drawing.Point(99, 382);
            this.btnPrintWantList.Name = "btnPrintWantList";
            this.btnPrintWantList.Size = new System.Drawing.Size(181, 27);
            this.btnPrintWantList.TabIndex = 36;
            this.btnPrintWantList.Text = "Print";
            this.btnPrintWantList.UseVisualStyleBackColor = true;
            this.btnPrintWantList.Click += new System.EventHandler(this.btnNumberOfOwnedPrint_Click);
            // 
            // txtTotalNumber
            // 
            this.txtTotalNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalNumber.Location = new System.Drawing.Point(327, 277);
            this.txtTotalNumber.Name = "txtTotalNumber";
            this.txtTotalNumber.Size = new System.Drawing.Size(77, 20);
            this.txtTotalNumber.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total Number of Comics Owned";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comicBookNumOwnedTableAdapter
            // 
            this.comicBookNumOwnedTableAdapter.ClearBeforeFill = true;
            // 
            // ComicsOwned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 434);
            this.Controls.Add(this.txtTotalNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintWantList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgNumOwned);
            this.Name = "ComicsOwned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number of Comics Owned";
            this.Load += new System.EventHandler(this.ComicsOwned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNumOwned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookNumOwnedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNumOwned;
        private ComicBookDataSet comicBookDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtShowAll;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.TextBox txtSearchOwn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrintWantList;
        private System.Windows.Forms.TextBox txtTotalNumber;
        private System.Windows.Forms.Label label1;
        private Comics.ComicBookDataSetTableAdapters.ComicBookNumOwnedTableAdapter comicBookNumOwnedTableAdapter;
        private System.Windows.Forms.BindingSource comicBookNumOwnedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfOwnedDataGridViewTextBoxColumn;
    }
}