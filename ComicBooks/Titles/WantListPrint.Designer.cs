namespace Comics
{
    partial class WantListPrint
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ComicBookDetails1TableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
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
            // reportViewer1
            // 
            reportDataSource1.Name = "ComicBookDataSet_ComicBookDetails1";
            reportDataSource1.Value = this.ComicBookDetails1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Comics.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(856, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // ComicBookDetails1TableAdapter
            // 
            this.ComicBookDetails1TableAdapter.ClearBeforeFill = true;
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
            // WantListPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 476);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WantListPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Want List - Printable View";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.WantListPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDetails1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComicBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ComicBookDetails1BindingSource;
        private ComicBookDataSet ComicBookDataSet;
        private Comics.ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter ComicBookDetails1TableAdapter;
        private System.Windows.Forms.Button btnClose;
    }
}