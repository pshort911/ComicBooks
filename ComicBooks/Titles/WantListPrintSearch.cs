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
    public partial class WantListPrintSearch : Form
    {
        public WantListPrintSearch()
        {
            InitializeComponent();
        }

        private void WantListPrintSearch_Load(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("SearchResults", Comics.WantList.SearchData);
            // TODO: This line of code loads data into the 'ComicBookDataSet.ComicBookDetails1' table. You can move, or remove it, as needed.
            this.ComicBookDetails1TableAdapter.Fill(this.ComicBookDataSet.ComicBookDetails1);
            ComicBookDetails1TableAdapter.FillWantSearch(this.ComicBookDataSet.ComicBookDetails1, Comics.WantList.SearchData);
            this.WantListPrintSearchRpt.LocalReport.SetParameters(new ReportParameter[] { p });
            this.WantListPrintSearchRpt.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}