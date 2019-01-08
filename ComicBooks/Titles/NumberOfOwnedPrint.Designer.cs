namespace Comics
{
    partial class NumberOfOwnedPrint
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
            this.comicBookNumOwnedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBookDataSet = new Comics.ComicBookDataSet();
            this.NumOwnReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.comicBookNumOwnedTableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookNumOwnedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookNumOwnedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).BeginInit();
            this.SuspendLayout();
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
            // NumOwnReportViewer
            // 
            reportDataSource1.Name = "ComicBookDataSet_ComicBookNumOwned";
            reportDataSource1.Value = this.comicBookNumOwnedBindingSource;
            this.NumOwnReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.NumOwnReportViewer.LocalReport.ReportEmbeddedResource = "Comics.Report3.rdlc";
            this.NumOwnReportViewer.Location = new System.Drawing.Point(12, 11);
            this.NumOwnReportViewer.Name = "NumOwnReportViewer";
            this.NumOwnReportViewer.Size = new System.Drawing.Size(856, 417);
            this.NumOwnReportViewer.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(274, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(374, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comicBookNumOwnedTableAdapter
            // 
            this.comicBookNumOwnedTableAdapter.ClearBeforeFill = true;
            // 
            // NumberOfOwnedPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 476);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.NumOwnReportViewer);
            this.Name = "NumberOfOwnedPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number of Owned List - Printable View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NumberOfOwnedPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comicBookNumOwnedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer NumOwnReportViewer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource comicBookNumOwnedBindingSource;
        private ComicBookDataSet comicBookDataSet;
        private Comics.ComicBookDataSetTableAdapters.ComicBookNumOwnedTableAdapter comicBookNumOwnedTableAdapter;
    }
}