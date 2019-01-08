using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comics
{
    public partial class NumberOfOwnedPrint : Form
    {
        public NumberOfOwnedPrint()
        {
            InitializeComponent();
        }

        private void NumberOfOwnedPrint_Load(object sender, EventArgs e)
        {
            this.comicBookNumOwnedTableAdapter.FillNumOwned(this.comicBookDataSet.ComicBookNumOwned);
            this.NumOwnReportViewer.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}