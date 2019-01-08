using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Comics
{
    public partial class OwnListPrint : Form
    {
        public OwnListPrint()
        {
            InitializeComponent();
        }

        private void OwnListPrint_Load(object sender, EventArgs e)
        {
            ComicBookDetails1TableAdapter.Fill(this.ComicBookDataSet.ComicBookDetails1);
            this.OwnReportViewer.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}