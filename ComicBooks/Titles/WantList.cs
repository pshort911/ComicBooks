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
    public partial class WantList : Form
    {
        public WantList()
        {
            InitializeComponent();
        }

        public static string SearchData = "";

        private void WantList_Load(object sender, EventArgs e)
        {
            LoadDataWantList();
        }

        private void LoadDataWantList()
        {
            this.comicBookDetails1TableAdapter.GetData();
            this.comicBookDetails1TableAdapter.Fill(this.comicBookDataSet.ComicBookDetails1);
            ProcessDataWantList();
        }

        private void ProcessDataWantList()
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

        private void btnPrintWantList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchWant.Text))
            {
                new WantListPrint().Show();
            }
            else
            {
                DialogResult myAnswer = MessageBox.Show("Do you want to print just your search?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (myAnswer == DialogResult.Yes)
                    new WantListPrintSearch().Show();
                else if (myAnswer == DialogResult.No)
                    new WantListPrint().Show();
                else
                    MessageBox.Show("Print Job Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            SearchData = txtSearchWant.Text;
            this.comicBookDetails1TableAdapter.GetDataWantSearch(txtSearchWant.Text);
            this.comicBookDetails1TableAdapter.FillWantSearch(this.comicBookDataSet.ComicBookDetails1, txtSearchWant.Text);
            ProcessDataWantList();
        }

        private void txtShowAll_Click(object sender, EventArgs e)
        {
            LoadDataWantList();
            txtSearchWant.Clear();
        }
    }
}