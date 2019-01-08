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
    public partial class DetailsIndividually : Form
    {
        public DetailsIndividually()
        {
            InitializeComponent();
        }

        private DataRow LastDataRow = null;
        private int RowIndex = 0;

        private void DetailsIndividually_Load(object sender, EventArgs e)
        {
            LastDataRow = ViewDetails.ThisDataRow;
            SetTextBoxes();
        }

        private void SetTextBoxes()
        {
            txtTitle.Text = LastDataRow.ItemArray[2].ToString();
            txtIssueNum.Text = LastDataRow.ItemArray[4].ToString();
            cbxOwn.Checked = (bool)LastDataRow.ItemArray[0];
            cbxWant.Checked = (bool)LastDataRow.ItemArray[1];
            cbxSpIssue.Checked = (bool)LastDataRow.ItemArray[3];
            txtIssueName.Text = LastDataRow.ItemArray[5].ToString();
            txtRating.Text = LastDataRow.ItemArray[6].ToString();
            txtGrade.Text = LastDataRow.ItemArray[7].ToString();
            txtDescription.Text = LastDataRow.ItemArray[8].ToString();
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
            ViewDetails.comicBookDetailsTableAdapterTemp.UpdateDetailsIndi(cbxOwn.Checked, cbxWant.Checked,
                txtTitle.Text, cbxSpIssue.Checked, Convert.ToInt32(txtIssueNum.Text),
                txtIssueName.Text, txtGrade.Text, txtDescription.Text);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            GetFromTextBoxes();
            ViewDetails.comicBookDetailsBindingSourceTemp.Position = RowIndex - 1;
            ViewDetails.ThisDataRow = ((DataRowView)ViewDetails.comicBookDetailsBindingSourceTemp.Current).Row;
            LastDataRow = ViewDetails.ThisDataRow;
            SetTextBoxes();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GetFromTextBoxes();
            ViewDetails.comicBookDetailsBindingSourceTemp.Position = RowIndex + 1;
            ViewDetails.ThisDataRow = ((DataRowView)ViewDetails.comicBookDetailsBindingSourceTemp.Current).Row;
            LastDataRow = ViewDetails.ThisDataRow;
            SetTextBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetFromTextBoxes();
            this.Close();
        }
    }
}