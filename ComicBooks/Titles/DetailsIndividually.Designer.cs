namespace Comics
{
    partial class DetailsIndividually
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumIssue = new System.Windows.Forms.Label();
            this.cbxSpIssue = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtIssueNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtIssueName = new System.Windows.Forms.TextBox();
            this.cbxWant = new System.Windows.Forms.CheckBox();
            this.cbxOwn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(16, 311);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(63, 23);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<<Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(85, 311);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(219, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Special Issue?";
            // 
            // lblNumIssue
            // 
            this.lblNumIssue.AutoSize = true;
            this.lblNumIssue.Location = new System.Drawing.Point(19, 44);
            this.lblNumIssue.Name = "lblNumIssue";
            this.lblNumIssue.Size = new System.Drawing.Size(72, 13);
            this.lblNumIssue.TabIndex = 5;
            this.lblNumIssue.Text = "Issue Number";
            // 
            // cbxSpIssue
            // 
            this.cbxSpIssue.AutoSize = true;
            this.cbxSpIssue.Location = new System.Drawing.Point(269, 44);
            this.cbxSpIssue.Name = "cbxSpIssue";
            this.cbxSpIssue.Size = new System.Drawing.Size(15, 14);
            this.cbxSpIssue.TabIndex = 6;
            this.cbxSpIssue.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(65, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(229, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtIssueNum
            // 
            this.txtIssueNum.Location = new System.Drawing.Point(97, 41);
            this.txtIssueNum.Name = "txtIssueNum";
            this.txtIssueNum.Size = new System.Drawing.Size(70, 20);
            this.txtIssueNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Want?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Own?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Issue Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(97, 176);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(197, 71);
            this.txtDescription.TabIndex = 15;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(233, 127);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(61, 20);
            this.txtRating.TabIndex = 16;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(97, 127);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(70, 20);
            this.txtGrade.TabIndex = 17;
            // 
            // txtIssueName
            // 
            this.txtIssueName.Location = new System.Drawing.Point(97, 84);
            this.txtIssueName.Name = "txtIssueName";
            this.txtIssueName.Size = new System.Drawing.Size(197, 20);
            this.txtIssueName.TabIndex = 18;
            // 
            // cbxWant
            // 
            this.cbxWant.AutoSize = true;
            this.cbxWant.Location = new System.Drawing.Point(233, 269);
            this.cbxWant.Name = "cbxWant";
            this.cbxWant.Size = new System.Drawing.Size(15, 14);
            this.cbxWant.TabIndex = 19;
            this.cbxWant.UseVisualStyleBackColor = true;
            // 
            // cbxOwn
            // 
            this.cbxOwn.AutoSize = true;
            this.cbxOwn.Location = new System.Drawing.Point(103, 269);
            this.cbxOwn.Name = "cbxOwn";
            this.cbxOwn.Size = new System.Drawing.Size(15, 14);
            this.cbxOwn.TabIndex = 20;
            this.cbxOwn.UseVisualStyleBackColor = true;
            // 
            // DetailsIndividually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(321, 348);
            this.Controls.Add(this.cbxOwn);
            this.Controls.Add(this.cbxWant);
            this.Controls.Add(this.txtIssueName);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIssueNum);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cbxSpIssue);
            this.Controls.Add(this.lblNumIssue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsIndividually";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Information / View Details Individually";
            this.Load += new System.EventHandler(this.DetailsIndividually_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumIssue;
        private System.Windows.Forms.CheckBox cbxSpIssue;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtIssueNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtIssueName;
        private System.Windows.Forms.CheckBox cbxWant;
        private System.Windows.Forms.CheckBox cbxOwn;
    }
}