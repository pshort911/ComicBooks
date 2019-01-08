using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comics
{
    public partial class WantListPrint : Form
    {
        public WantListPrint()
        {
            InitializeComponent();
        }

        private void WantListPrint_Load(object sender, EventArgs e)
        {
            ComicBookDetails1TableAdapter.Fill(this.ComicBookDataSet.ComicBookDetails1);
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}