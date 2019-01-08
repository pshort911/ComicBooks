using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Comics
{
    public partial class OwnListPrintSearch : Form
    {
        public OwnListPrintSearch()
        {
            InitializeComponent();
        }

        private void OwnListPrintSearch_Load(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("SearchResults", Comics.OwnList.SearchData);
            // TODO: This line of code loads data into the 'ComicBookDataSet.ComicBookDetails1' table. You can move, or remove it, as needed.
            this.ComicBookDetails1TableAdapter.Fill(this.ComicBookDataSet.ComicBookDetails1);
            ComicBookDetails1TableAdapter.FillOwnSearch(this.ComicBookDataSet.ComicBookDetails1, Comics.OwnList.SearchData);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p });
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}