namespace Comics
{
    partial class WantListPrintSearch
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ComicBookDetails1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComicBookDataSet = new Comics.ComicBookDataSet();
            this.WantListPrintSearchRpt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.ComicBookDetails1TableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDetails1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ComicBookDetails1BindingSource
            // 
            this.ComicBookDetails1BindingSource.DataMember = "ComicBookDetails1";
            this.ComicBookDetails1BindingSource.DataSource = this.ComicBookDataSet;
            // 
            // ComicBookDataSet
            // 
            this.ComicBookDataSet.DataSetName = "ComicBookDataSet";
            this.ComicBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WantListPrintSearchRpt
            // 
            reportDataSource1.Name = "ComicBookDataSet_ComicBookDetails1";
            reportDataSource1.Value = this.ComicBookDetails1BindingSource;
            this.WantListPrintSearchRpt.LocalReport.DataSources.Add(reportDataSource1);
            this.WantListPrintSearchRpt.LocalReport.ReportEmbeddedResource = "Comics.Report1a.rdlc";
            this.WantListPrintSearchRpt.Location = new System.Drawing.Point(12, 12);
            this.WantListPrintSearchRpt.Name = "WantListPrintSearchRpt";
            this.WantListPrintSearchRpt.Size = new System.Drawing.Size(856, 417);
            this.WantListPrintSearchRpt.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(374, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ComicBookDetails1TableAdapter
            // 
            this.ComicBookDetails1TableAdapter.ClearBeforeFill = true;
            // 
            // WantListPrintSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.WantListPrintSearchRpt);
            this.Name = "WantListPrintSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Want List - Print Search Results";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WantListPrintSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer WantListPrintSearchRpt;
        private System.Windows.Forms.BindingSource ComicBookDetails1BindingSource;
        private ComicBookDataSet ComicBookDataSet;
        private Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter ComicBookDetails1TableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}