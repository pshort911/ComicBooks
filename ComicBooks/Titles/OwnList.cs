using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Comics
{
    public partial class OwnList : Form
    {
        public OwnList()
        {
            InitializeComponent();
        }

        public static string SearchData = "";

        private void OwnList_Load(object sender, EventArgs e)
        {
            LoadDataOwnList();
        }

        private void LoadDataOwnList()
        {
            this.comicBookDetails1TableAdapter.GetDataOwn();
            this.comicBookDetails1TableAdapter.FillOwn(this.comicBookDataSet.ComicBookDetails1);
            ProcessDataOwnList();
        }

        private void ProcessDataOwnList()
        {
            this.comicBookDetails1BindingSource.DataSource = this.comicBookDataSet.ComicBookDetails1;
            this.dataGridView1.DataSource = this.comicBookDetails1BindingSource;
            this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            this.txtTotalNumber.Text = this.comicBookDataSet.ComicBookDetails1.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            SearchData = txtSearchOwn.Text;
            this.comicBookDetails1TableAdapter.GetDataOwnSearch(txtSearchOwn.Text);
            this.comicBookDetails1TableAdapter.FillOwnSearch(this.comicBookDataSet.ComicBookDetails1, txtSearchOwn.Text);
            ProcessDataOwnList();
        }

        private void txtShowAll_Click(object sender, EventArgs e)
        {
            LoadDataOwnList();
        }

        private void btnPrintOwnList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchOwn.Text))
            {
                new OwnListPrint().Show();
            }
            else
            {
                DialogResult myAnswer = MessageBox.Show("Do you want to print just your search?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (myAnswer == DialogResult.Yes)
                    new OwnListPrintSearch().Show();
                else if (myAnswer == DialogResult.No)
                    new OwnListPrint().Show();
                else
                    MessageBox.Show("Print Job Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}