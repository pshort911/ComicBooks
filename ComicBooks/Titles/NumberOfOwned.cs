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
    public partial class ComicsOwned : Form
    {
        public ComicsOwned()
        {
            InitializeComponent();
        }

        public static string SearchData = "";

        private void ComicsOwned_Load(object sender, EventArgs e)
        {
            LoadDataOwnList();
        }

        private void LoadDataOwnList()
        {
            this.txtSearchOwn.Clear();
            this.comicBookNumOwnedTableAdapter.GetDataNumOwned();
            this.comicBookNumOwnedTableAdapter.FillNumOwned(this.comicBookDataSet.ComicBookNumOwned);
            ProcessDataOwnList();
        }

        private void ProcessDataOwnList()
        {
            this.comicBookNumOwnedBindingSource.DataSource = this.comicBookDataSet.ComicBookNumOwned;
            this.dgNumOwned.DataSource = this.comicBookNumOwnedBindingSource;
            this.dgNumOwned.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int total = 0;
            for (int i = 0; i < this.dgNumOwned.RowCount; i++)
            {
                total += Convert.ToInt32(dgNumOwned.Rows[i].Cells[1].Value);
            }
            this.txtTotalNumber.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            SearchData = txtSearchOwn.Text;
            this.comicBookNumOwnedTableAdapter.GetDataNumOwnedSearch(txtSearchOwn.Text);
            this.comicBookNumOwnedTableAdapter.FillNumOwnedSearch(this.comicBookDataSet.ComicBookNumOwned, txtSearchOwn.Text);
            ProcessDataOwnList();
        }

        private void txtShowAll_Click(object sender, EventArgs e)
        {
            LoadDataOwnList();
        }

        private void btnNumberOfOwnedPrint_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchOwn.Text))
            {
                new NumberOfOwnedPrint().Show();
            }
            else
            {
                DialogResult myAnswer = MessageBox.Show("Do you want to print just your search?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (myAnswer == DialogResult.Yes)
                    new NumberOfOwnedPrintSearch().Show();
                else if (myAnswer == DialogResult.No)
                    new NumberOfOwnedPrint().Show();
                else
                    MessageBox.Show("Print Job Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void fillNumOwnedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.comicBookNumOwnedTableAdapter.FillNumOwned(this.comicBookDataSet.ComicBookNumOwned);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}