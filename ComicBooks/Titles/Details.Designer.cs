namespace Comics
{
    partial class ViewDetails
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
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.ownDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wantDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialIssueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.issueNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comicBookDetails1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBookDataSet1 = new Comics.ComicBookDataSet();
            this.btnCloseDetails = new System.Windows.Forms.Button();
            this.comicBookDetails1TableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter();
            this.cbxOwn = new System.Windows.Forms.CheckBox();
            this.cbxWant = new System.Windows.Forms.CheckBox();
            this.txtIssueName = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIssueNum = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbxSpIssue = new System.Windows.Forms.CheckBox();
            this.lblNumIssue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTotalNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDetails1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetails
            // 
            this.dgDetails.AllowUserToAddRows = false;
            this.dgDetails.AllowUserToOrderColumns = true;
            this.dgDetails.AutoGenerateColumns = false;
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownDataGridViewCheckBoxColumn,
            this.wantDataGridViewCheckBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.specialIssueDataGridViewCheckBoxColumn,
            this.issueNumDataGridViewTextBoxColumn,
            this.issueNameDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgDetails.DataSource = this.comicBookDetails1BindingSource;
            this.dgDetails.Location = new System.Drawing.Point(12, 33);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.Size = new System.Drawing.Size(644, 338);
            this.dgDetails.TabIndex = 0;
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
            // specialIssueDataGridViewCheckBoxColumn
            // 
            this.specialIssueDataGridViewCheckBoxColumn.DataPropertyName = "SpecialIssue";
            this.specialIssueDataGridViewCheckBoxColumn.HeaderText = "SpecialIssue";
            this.specialIssueDataGridViewCheckBoxColumn.Name = "specialIssueDataGridViewCheckBoxColumn";
            // 
            // issueNumDataGridViewTextBoxColumn
            // 
            this.issueNumDataGridViewTextBoxColumn.DataPropertyName = "IssueNum";
            this.issueNumDataGridViewTextBoxColumn.HeaderText = "IssueNum";
            this.issueNumDataGridViewTextBoxColumn.Name = "issueNumDataGridViewTextBoxColumn";
            // 
            // issueNameDataGridViewTextBoxColumn
            // 
            this.issueNameDataGridViewTextBoxColumn.DataPropertyName = "IssueName";
            this.issueNameDataGridViewTextBoxColumn.HeaderText = "IssueName";
            this.issueNameDataGridViewTextBoxColumn.Name = "issueNameDataGridViewTextBoxColumn";
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
            this.descriptionDataGridViewTextBoxColumn.Width = 500;
            // 
            // comicBookDetails1BindingSource
            // 
            this.comicBookDetails1BindingSource.DataMember = "ComicBookDetails1";
            this.comicBookDetails1BindingSource.DataSource = this.comicBookDataSet1;
            // 
            // comicBookDataSet1
            // 
            this.comicBookDataSet1.DataSetName = "ComicBookDataSet";
            this.comicBookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCloseDetails
            // 
            this.btnCloseDetails.Location = new System.Drawing.Point(183, 432);
            this.btnCloseDetails.Name = "btnCloseDetails";
            this.btnCloseDetails.Size = new System.Drawing.Size(641, 23);
            this.btnCloseDetails.TabIndex = 1;
            this.btnCloseDetails.Text = "Close Window And Save Changes";
            this.btnCloseDetails.UseVisualStyleBackColor = true;
            this.btnCloseDetails.Click += new System.EventHandler(this.btnCloseDetails_Click);
            // 
            // comicBookDetails1TableAdapter
            // 
            this.comicBookDetails1TableAdapter.ClearBeforeFill = true;
            // 
            // cbxOwn
            // 
            this.cbxOwn.AutoSize = true;
            this.cbxOwn.Location = new System.Drawing.Point(790, 306);
            this.cbxOwn.Name = "cbxOwn";
            this.cbxOwn.Size = new System.Drawing.Size(15, 14);
            this.cbxOwn.TabIndex = 61;
            this.cbxOwn.UseVisualStyleBackColor = true;
            this.cbxOwn.CheckedChanged += new System.EventHandler(this.cbxOwn_CheckedChanged);
            // 
            // cbxWant
            // 
            this.cbxWant.AutoSize = true;
            this.cbxWant.Location = new System.Drawing.Point(878, 306);
            this.cbxWant.Name = "cbxWant";
            this.cbxWant.Size = new System.Drawing.Size(15, 14);
            this.cbxWant.TabIndex = 60;
            this.cbxWant.UseVisualStyleBackColor = true;
            this.cbxWant.CheckedChanged += new System.EventHandler(this.cbxWant_CheckedChanged);
            // 
            // txtIssueName
            // 
            this.txtIssueName.Location = new System.Drawing.Point(772, 121);
            this.txtIssueName.Name = "txtIssueName";
            this.txtIssueName.Size = new System.Drawing.Size(141, 20);
            this.txtIssueName.TabIndex = 59;
            this.txtIssueName.TextChanged += new System.EventHandler(this.txtIssueName_TextChanged);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(772, 164);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(70, 20);
            this.txtGrade.TabIndex = 58;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(772, 213);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 71);
            this.txtDescription.TabIndex = 56;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Issue Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(749, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Own?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Want?";
            // 
            // txtIssueNum
            // 
            this.txtIssueNum.Location = new System.Drawing.Point(784, 78);
            this.txtIssueNum.Name = "txtIssueNum";
            this.txtIssueNum.Size = new System.Drawing.Size(40, 20);
            this.txtIssueNum.TabIndex = 49;
            this.txtIssueNum.TextChanged += new System.EventHandler(this.txtIssueNum_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(772, 43);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(153, 20);
            this.txtTitle.TabIndex = 48;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // cbxSpIssue
            // 
            this.cbxSpIssue.AutoSize = true;
            this.cbxSpIssue.Location = new System.Drawing.Point(914, 81);
            this.cbxSpIssue.Name = "cbxSpIssue";
            this.cbxSpIssue.Size = new System.Drawing.Size(15, 14);
            this.cbxSpIssue.TabIndex = 47;
            this.cbxSpIssue.UseVisualStyleBackColor = true;
            this.cbxSpIssue.CheckedChanged += new System.EventHandler(this.cbxSpIssue_CheckedChanged);
            // 
            // lblNumIssue
            // 
            this.lblNumIssue.AutoSize = true;
            this.lblNumIssue.Location = new System.Drawing.Point(706, 81);
            this.lblNumIssue.Name = "lblNumIssue";
            this.lblNumIssue.Size = new System.Drawing.Size(72, 13);
            this.lblNumIssue.TabIndex = 46;
            this.lblNumIssue.Text = "Issue Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Special Issue?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Title";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(865, 348);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 23);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(703, 348);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(63, 23);
            this.btnPrev.TabIndex = 42;
            this.btnPrev.Text = "<<Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(784, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 23);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTotalNumber
            // 
            this.txtTotalNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalNumber.Location = new System.Drawing.Point(549, 390);
            this.txtTotalNumber.Name = "txtTotalNumber";
            this.txtTotalNumber.Size = new System.Drawing.Size(77, 20);
            this.txtTotalNumber.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Total Number of Issues for this Title";
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 494);
            this.Controls.Add(this.txtTotalNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbxOwn);
            this.Controls.Add(this.cbxWant);
            this.Controls.Add(this.txtIssueName);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIssueNum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cbxSpIssue);
            this.Controls.Add(this.lblNumIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dgDetails);
            this.Controls.Add(this.btnCloseDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetails;
        private System.Windows.Forms.Button btnCloseDetails;
        private ComicBookDataSet comicBookDataSet1;
        private System.Windows.Forms.BindingSource comicBookDetails1BindingSource;
        private Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter comicBookDetails1TableAdapter;
        private System.Windows.Forms.CheckBox cbxOwn;
        private System.Windows.Forms.CheckBox cbxWant;
        private System.Windows.Forms.TextBox txtIssueName;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIssueNum;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox cbxSpIssue;
        private System.Windows.Forms.Label lblNumIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTotalNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ownDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wantDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn specialIssueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}