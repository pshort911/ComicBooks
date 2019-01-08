using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comics
{
    public partial class NumberOfOwnedPrintSearch : Form
    {
        public NumberOfOwnedPrintSearch()
        {
            InitializeComponent();
        }

        private void NumberOfOwnedPrintSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'comicBookDataSet.ComicBookNumOwned' table. You can move, or remove it, as needed.
            this.comicBookNumOwnedTableAdapter.FillNumOwned(this.comicBookDataSet.ComicBookNumOwned);
            this.comicBookNumOwnedTableAdapter.FillNumOwnedSearch(this.comicBookDataSet.ComicBookNumOwned, Comics.ComicsOwned.SearchData);
            this.NumOwnedPrintSearchReportViewer.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}