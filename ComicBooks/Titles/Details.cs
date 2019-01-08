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
    public partial class ViewDetails : Form
    {
        public static GeneratedTableAdapter comicBookDetailsTableAdapterTemp;
        public static BindingSource comicBookDetailsBindingSourceTemp;
        public static string detailCommand;
        public static DataRow ThisDataRow;
        public static string MostRecentSelectString = "";
        private DataRow LastDataRow;
        private int RowIndex = 0;
        bool UpdatedText = false;

        public ViewDetails()
        {
            InitializeComponent();
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            comicBookDetailsTableAdapterTemp = new GeneratedTableAdapter();
            comicBookDetailsBindingSourceTemp = new BindingSource();
            comicBookDetailsBindingSourceTemp.PositionChanged += new System.EventHandler(comicBookDetailsBindingSource_PositionChanged);
            LoadData(Comics.Titles.SelectCommand);
        }

        public void LoadData(string selectCommand)
        {
            comicBookDetailsTableAdapterTemp.myCommandCollection[0].CommandText = selectCommand;
            comicBookDetailsTableAdapterTemp.GetData();
            comicBookDetailsTableAdapterTemp.Fill(this.comicBookDataSet1.ComicBookDetails1);
            comicBookDetailsBindingSourceTemp.DataSource = this.comicBookDataSet1.ComicBookDetails1;
            this.dgDetails.DataSource = comicBookDetailsBindingSourceTemp;
            this.dgDetails.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            MostRecentSelectString = selectCommand;
            this.txtTotalNumber.Text = this.comicBookDataSet1.ComicBookDetails1.Count.ToString();
        }

        private void comicBookDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (comicBookDetailsBindingSourceTemp.Current != null)
            {
                ThisDataRow = ((DataRowView)comicBookDetailsBindingSourceTemp.Current).Row;
                LastDataRow = ThisDataRow;
                SetTextBoxes();
            }
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            comicBookDetailsTableAdapterTemp.Update(this.comicBookDataSet1.ComicBookDetails1);
            comicBookDetailsTableAdapterTemp.Dispose();
            Close();
        }

        private void btnUpdateIssues_Click(object sender, EventArgs e)
        {
            try
            {
                comicBookDetailsTableAdapterTemp.Update(this.comicBookDataSet1.ComicBookDetails1);
                MessageBox.Show("Changes Accepted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comicBookDataSet1.RejectChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comicBookDetailsTableAdapterTemp.Dispose();
            Close();
        }

        private void SetTextBoxes()
        {
            txtTitle.Text = LastDataRow.ItemArray[2].ToString();
            txtIssueNum.Text = LastDataRow.ItemArray[4].ToString();
            cbxOwn.Checked = (bool)LastDataRow.ItemArray[0];
            cbxWant.Checked = (bool)LastDataRow.ItemArray[1];
            cbxSpIssue.Checked = (bool)LastDataRow.ItemArray[3];
            txtIssueName.Text = LastDataRow.ItemArray[5].ToString();
            //txtRating.Text = LastDataRow.ItemArray[6].ToString();
            txtGrade.Text = LastDataRow.ItemArray[6].ToString();
            txtDescription.Text = LastDataRow.ItemArray[7].ToString();
            RowIndex = LastDataRow.Table.Rows.IndexOf(LastDataRow);

            if (RowIndex == 0)
                btnPrev.Enabled = false;
            else
                btnPrev.Enabled = true;

            if (RowIndex == LastDataRow.Table.Rows.Count - 1)
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
        }

        private void GetFromTextBoxes()
        {
            comicBookDetailsTableAdapterTemp.UpdateDetailsIndi(cbxOwn.Checked, cbxWant.Checked,
                txtTitle.Text, cbxSpIssue.Checked, Convert.ToInt32(txtIssueNum.Text),
                txtIssueName.Text, txtGrade.Text, txtDescription.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (UpdatedText == true)
                btnUpdate_Click(sender, e);
            GetFromTextBoxes();
            comicBookDetailsBindingSourceTemp.Position = RowIndex - 1;
            ThisDataRow = ((DataRowView)comicBookDetailsBindingSourceTemp.Current).Row;
            LastDataRow = ThisDataRow;
            SetTextBoxes();
            UpdatedText = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetFromTextBoxes();
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (UpdatedText == true)
                btnUpdate_Click(sender, e);
            GetFromTextBoxes();
            comicBookDetailsBindingSourceTemp.Position = RowIndex + 1;
            ThisDataRow = ((DataRowView)comicBookDetailsBindingSourceTemp.Current).Row;
            LastDataRow = ThisDataRow;
            SetTextBoxes();
            UpdatedText = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int TempPosition = comicBookDetailsBindingSourceTemp.Position;
            GetFromTextBoxes();
            LoadData(MostRecentSelectString);
            comicBookDetailsBindingSourceTemp.Position = TempPosition;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void txtIssueNum_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void cbxSpIssue_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void txtIssueName_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void txtRating_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void cbxOwn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

        private void cbxWant_CheckedChanged(object sender, EventArgs e)
        {
            UpdatedText = true;
        }

    }

    public partial class GeneratedTableAdapter : ComicBookDataSetTableAdapters.ComicBookDetails1TableAdapter
    {
        public SqlCommand[] myCommandCollection {get{return this.CommandCollection;}}
    }

}