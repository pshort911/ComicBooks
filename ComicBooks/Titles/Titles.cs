using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;


namespace Comics
{
    public partial class Titles : Form
    {
        public static string SelectCommand;
        private static DataRow ThisDataRow;
        private static Server srvSql;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Titles());
        }

        public Titles()
        {
            InitializeComponent();
        }

        private void Titles_Load(object sender, EventArgs e)
        {
            //if (this.txtComicBookTitle.Focused || this.txtFirst.Focused || this.txtLast.Focused || this.txtNumOfSpecialIssues.Focused)
            //    this.AcceptButton = this.btnAddNew;
            //else if (this.txtComicTitle2.Focused || this.txtFirstMod.Focused || this.txtLastMod.Focused || this.txtNumOfSpIssues2.Focused)
            //    this.AcceptButton = this.btnModify;
            //else if (this.txtSearch.Focused)
            //    this.AcceptButton = this.button2;
            LoadData();
            this.comicBookTitleBindingSource.PositionChanged += new EventHandler(comicBookTitleBindingSource_PositionChanged);
        }

        private void LoadData()
        {
            this.comicBookTitleTableAdapter.GetData();
            this.comicBookTitleTableAdapter.Fill(this.comicBookDataSet.ComicBookTitle);
            ProcessData();
        }

        private void ProcessData()
        {
            this.comicBookTitleBindingSource.DataSource = this.comicBookDataSet.ComicBookTitle;
            this.dataGridView1.DataSource = this.comicBookTitleBindingSource;
            if (dataGridView1.CurrentRow != null)
            {
                this.dataGridView1.CurrentRow.Selected = true;
                ThisDataRow = ((DataRowView)this.comicBookTitleBindingSource.Current).Row;
                txtComicTitle2.Text = ThisDataRow.ItemArray[0].ToString();
                txtFirstMod.Text = ThisDataRow.ItemArray[1].ToString();
                txtLastMod.Text = ThisDataRow.ItemArray[2].ToString();
                txtNumOfIssues2.Text = ThisDataRow.ItemArray[3].ToString();
                txtNumOfSpIssues2.Text = ThisDataRow.ItemArray[4].ToString();
            }
            else
            {
                txtComicTitle2.Clear();
                txtFirstMod.Clear();
                txtLastMod.Clear();
                txtNumOfIssues2.Clear();
                txtNumOfSpIssues2.Clear();
            }
        }

        private void AddNewComic(string ComicTitle, int FirstIssue, int LastIssue, int NumOfSpecialIssues)
        {
            int NumOfIssues = LastIssue - FirstIssue + 1;
            this.comicBookTitleTableAdapter.InsertTitles(ComicTitle, FirstIssue, LastIssue, NumOfIssues, NumOfSpecialIssues);
            MessageBox.Show("Title Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddIssues(ComicTitle, FirstIssue, LastIssue, NumOfSpecialIssues);
            LoadData();
        }

        private void AddIssues(string ComicBookTitle, int FirstIssue, int LastIssue, int NumOfSpecialIssues)
        {
            for (int i = FirstIssue; i <= LastIssue; i++)
                this.comicBookTitleTableAdapter.InsertDetails1(ComicBookTitle, i);
            for (int j = 1; j <= (NumOfSpecialIssues); j++)
                this.comicBookTitleTableAdapter.InsertDetails2(ComicBookTitle, j, j.ToString());
            MessageBox.Show("Issues Added Successfully to Details Database", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void comicBookTitleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.comicBookTitleBindingSource.Current != null)
            {
                ThisDataRow = ((DataRowView)this.comicBookTitleBindingSource.Current).Row;
                txtComicTitle2.Text = ThisDataRow.ItemArray[0].ToString();
                txtFirstMod.Text = ThisDataRow.ItemArray[1].ToString();
                txtLastMod.Text = ThisDataRow.ItemArray[2].ToString();
                txtNumOfIssues2.Text = ThisDataRow.ItemArray[3].ToString();
                txtNumOfSpIssues2.Text = ThisDataRow.ItemArray[4].ToString();
            }
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            AddNewComic(txtComicBookTitle.Text, Convert.ToInt32(txtFirst.Text), Convert.ToInt32(txtLast.Text), Convert.ToInt32(txtNumOfSpecialIssues.Text));
            txtComicBookTitle.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtNumOfSpecialIssues.Clear();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the title(s) and all associated issues?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                        {
                            this.comicBookTitleTableAdapter.Delete(dr.Cells[0].Value.ToString(), Convert.ToInt32(dr.Cells[1].Value), Convert.ToInt32(dr.Cells[2].Value), Convert.ToInt32(dr.Cells[3].Value), Convert.ToInt32(dr.Cells[4].Value));
                            this.comicBookTitleTableAdapter.DeleteDetails(dr.Cells[0].Value.ToString());
                        }
                        LoadData();
                        MessageBox.Show("Title(s) deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                        MessageBox.Show("No Titles were deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Please select a title to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comicBookDataSet.RejectChanges();
                dataGridView1.Refresh();
            }
        }

        private void txtShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
            textBox1.Clear();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                LoadData();
            else
            {
                try
                {
                    this.comicBookTitleTableAdapter.GetDataSearch(textBox1.Text);
                    this.comicBookTitleTableAdapter.FillSearch(this.comicBookDataSet.ComicBookTitle, textBox1.Text);
                    ProcessData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comicBookDataSet.RejectChanges();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DataGridViewRow[] myRow = new DataGridViewRow[dataGridView1.SelectedRows.Count];
            int counter = 0;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    myRow[counter] = dr;
                    counter++;
                }
                StringBuilder SelectString = new StringBuilder();
                SelectString.Append("Select * From ComicBookDetails WHERE (Title LIKE '" + myRow[0].Cells[0].Value.ToString() + "')");     
                for (int i = 1; i < myRow.Length; i++)
                    SelectString.Append("OR (Title LIKE '" + myRow[i].Cells[0].Value.ToString() + "')");
                SelectCommand = SelectString.ToString();
                new ViewDetails().Show();
            }
        }

        private void myWantListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WantList().Show();
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myOwnListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OwnList().Show();
        }

        private void goToDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCommand = "SELECT * FROM ComicBookDetails";
            new ViewDetails().Show();
            this.Hide();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult myResult = MessageBox.Show("Are you sure you want to modify this title?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (myResult == DialogResult.Yes)
                {
                    int NumOfIssues = Convert.ToInt32(txtLastMod.Text) - Convert.ToInt32(txtFirstMod.Text) + 1;
                    if (Convert.ToInt32(txtNumOfSpIssues2.Text) < Convert.ToInt32(ThisDataRow.ItemArray[4].ToString()) ||
                            NumOfIssues < Convert.ToInt32(ThisDataRow.ItemArray[3].ToString()))
                    {
                        MessageBox.Show("No Changes Were Made; You cannot lower the number of issues or special issues", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtComicTitle2.Text = ThisDataRow.ItemArray[0].ToString();
                        txtFirstMod.Text = ThisDataRow.ItemArray[1].ToString();
                        txtLastMod.Text = ThisDataRow.ItemArray[2].ToString();
                        txtNumOfIssues2.Text = ThisDataRow.ItemArray[3].ToString();
                        txtNumOfSpIssues2.Text = ThisDataRow.ItemArray[4].ToString();
                    }
                    else
                    {
                        this.comicBookTitleTableAdapter.UpdateTitles(txtComicTitle2.Text, Convert.ToInt32(txtFirstMod.Text), Convert.ToInt32(txtLastMod.Text), NumOfIssues, Convert.ToInt32(txtNumOfSpIssues2.Text), ThisDataRow.ItemArray[0].ToString());
                        if (NumOfIssues > Convert.ToInt32(ThisDataRow.ItemArray[3].ToString()))
                        {
                            for (int i = Convert.ToInt32(ThisDataRow.ItemArray[3].ToString()) + 1; i <= NumOfIssues; i++)
                            {
                                this.comicBookTitleTableAdapter.InsertDetails1(txtComicTitle2.Text, i);
                            }
                        }
                        if (Convert.ToInt32(txtNumOfSpIssues2.Text) > Convert.ToInt32(ThisDataRow.ItemArray[2].ToString()))
                        {
                            for (int i = Convert.ToInt32(ThisDataRow.ItemArray[4].ToString()) + 1; i <= Convert.ToInt32(txtNumOfSpIssues2.Text); i++)
                            {
                                this.comicBookTitleTableAdapter.InsertDetails2(txtComicTitle2.Text, i, i.ToString());
                            }
                        }
                        MessageBox.Show("Changes Accepted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("No Changes Were Made", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtComicTitle2.Text = ThisDataRow.ItemArray[0].ToString();
                    txtFirstMod.Text = ThisDataRow.ItemArray[1].ToString();
                    txtLastMod.Text = ThisDataRow.ItemArray[2].ToString();
                    txtNumOfIssues2.Text = ThisDataRow.ItemArray[3].ToString();
                    txtNumOfSpIssues2.Text = ThisDataRow.ItemArray[4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comicBookDataSet.RejectChanges();
            }
        }

        private void backupAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to backup all of your files?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (myResult == DialogResult.Yes)
            {
                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                //saveFileDialog1.Filter = "MDF files (*.mdf)|*.mdf";
                //saveFileDialog1.FilterIndex = 1;
                //saveFileDialog1.RestoreDirectory = true;

                srvSql = new Server(ConfigurationManager.ConnectionStrings["Comics.Properties.Settings.ComicBookConnectionString"].ConnectionString);

                // Create a new backup operation
                Backup bkpDatabase = new Backup();

                // Set the backup type to a database backup
                bkpDatabase.Action = BackupActionType.Database;

                // Set the database that we want to perform a backup on
                bkpDatabase.Database = null;
            }
            else
            {
            }


        }

        private void numberOwnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ComicsOwned().Show();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("Are you sure you want to backup your comic database (current to previous day's entries)?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (myResult == DialogResult.Yes)
            {
                System.Diagnostics.Process proc; // Declare New Process
                proc = System.Diagnostics.Process.Start("C://Program Files/PatShort/ComicBooks/BackupToThumbDrive.bat"); // run Backup.bat from command line.
                proc.WaitForExit(); // Waits for the process to end. 
            }

        }

    }
}
