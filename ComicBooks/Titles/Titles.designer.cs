namespace Comics
{
    partial class Titles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myWantListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOwnListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOwnedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtNumOfSpIssues2 = new System.Windows.Forms.TextBox();
            this.txtNumOfIssues2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComicTitle2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComicBookTitle = new System.Windows.Forms.Label();
            this.txtComicBookTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumOfSpecialIssues = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLastMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtShowAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numIssuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSpIssuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comicBookTitleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comicBookDataSet = new Comics.ComicBookDataSet();
            this.comicBookTitleTableAdapter = new Comics.ComicBookDataSetTableAdapters.ComicBookTitleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookTitleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "--";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.firstIssueDataGridViewTextBoxColumn,
            this.lastIssueDataGridViewTextBoxColumn,
            this.numIssuesDataGridViewTextBoxColumn,
            this.numSpIssuesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comicBookTitleBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(332, 42);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(463, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(816, 197);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(107, 124);
            this.btnDeleteSelected.TabIndex = 17;
            this.btnDeleteSelected.Text = "Delete Selected Titles";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(816, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 126);
            this.button1.TabIndex = 16;
            this.button1.Text = "Go to Details for Selected Title";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(816, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 213);
            this.button2.TabIndex = 18;
            this.button2.Text = "Close Window";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.backupToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(958, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToDetailsToolStripMenuItem,
            this.myWantListToolStripMenuItem,
            this.myOwnListToolStripMenuItem,
            this.numberOwnedToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // goToDetailsToolStripMenuItem
            // 
            this.goToDetailsToolStripMenuItem.Name = "goToDetailsToolStripMenuItem";
            this.goToDetailsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.goToDetailsToolStripMenuItem.Text = "Details for All Books";
            this.goToDetailsToolStripMenuItem.Click += new System.EventHandler(this.goToDetailsToolStripMenuItem_Click);
            // 
            // myWantListToolStripMenuItem
            // 
            this.myWantListToolStripMenuItem.Name = "myWantListToolStripMenuItem";
            this.myWantListToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.myWantListToolStripMenuItem.Text = "My Want List";
            this.myWantListToolStripMenuItem.Click += new System.EventHandler(this.myWantListToolStripMenuItem_Click);
            // 
            // myOwnListToolStripMenuItem
            // 
            this.myOwnListToolStripMenuItem.Name = "myOwnListToolStripMenuItem";
            this.myOwnListToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.myOwnListToolStripMenuItem.Text = "My Own List";
            this.myOwnListToolStripMenuItem.Click += new System.EventHandler(this.myOwnListToolStripMenuItem_Click);
            // 
            // numberOwnedToolStripMenuItem
            // 
            this.numberOwnedToolStripMenuItem.Name = "numberOwnedToolStripMenuItem";
            this.numberOwnedToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.numberOwnedToolStripMenuItem.Text = "Number of Comics Owned";
            this.numberOwnedToolStripMenuItem.Click += new System.EventHandler(this.numberOwnedToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // backupAllToolStripMenuItem
            // 
            this.backupAllToolStripMenuItem.Name = "backupAllToolStripMenuItem";
            this.backupAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupAllToolStripMenuItem.Text = "Backup All";
            this.backupAllToolStripMenuItem.Click += new System.EventHandler(this.backupAllToolStripMenuItem_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(6, 155);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(274, 25);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "Modify Existing Title";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtNumOfSpIssues2
            // 
            this.txtNumOfSpIssues2.Location = new System.Drawing.Point(148, 121);
            this.txtNumOfSpIssues2.Name = "txtNumOfSpIssues2";
            this.txtNumOfSpIssues2.Size = new System.Drawing.Size(46, 20);
            this.txtNumOfSpIssues2.TabIndex = 3;
            // 
            // txtNumOfIssues2
            // 
            this.txtNumOfIssues2.Location = new System.Drawing.Point(110, 86);
            this.txtNumOfIssues2.Name = "txtNumOfIssues2";
            this.txtNumOfIssues2.ReadOnly = true;
            this.txtNumOfIssues2.Size = new System.Drawing.Size(46, 20);
            this.txtNumOfIssues2.TabIndex = 29;
            this.txtNumOfIssues2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Number of Special Issues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Number of Issues";
            // 
            // txtComicTitle2
            // 
            this.txtComicTitle2.BackColor = System.Drawing.SystemColors.Control;
            this.txtComicTitle2.Location = new System.Drawing.Point(106, 13);
            this.txtComicTitle2.Name = "txtComicTitle2";
            this.txtComicTitle2.ReadOnly = true;
            this.txtComicTitle2.Size = new System.Drawing.Size(150, 20);
            this.txtComicTitle2.TabIndex = 26;
            this.txtComicTitle2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Comic Book Title";
            // 
            // lblComicBookTitle
            // 
            this.lblComicBookTitle.AutoSize = true;
            this.lblComicBookTitle.Location = new System.Drawing.Point(15, 16);
            this.lblComicBookTitle.Name = "lblComicBookTitle";
            this.lblComicBookTitle.Size = new System.Drawing.Size(87, 13);
            this.lblComicBookTitle.TabIndex = 7;
            this.lblComicBookTitle.Text = "Comic Book Title";
            // 
            // txtComicBookTitle
            // 
            this.txtComicBookTitle.Location = new System.Drawing.Point(106, 13);
            this.txtComicBookTitle.Name = "txtComicBookTitle";
            this.txtComicBookTitle.Size = new System.Drawing.Size(150, 20);
            this.txtComicBookTitle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Number of Special Issues";
            // 
            // txtNumOfSpecialIssues
            // 
            this.txtNumOfSpecialIssues.Location = new System.Drawing.Point(146, 121);
            this.txtNumOfSpecialIssues.Name = "txtNumOfSpecialIssues";
            this.txtNumOfSpecialIssues.Size = new System.Drawing.Size(58, 20);
            this.txtNumOfSpecialIssues.TabIndex = 11;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(6, 157);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(274, 25);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Add New Title";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.txtNumOfSpecialIssues);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComicBookTitle);
            this.groupBox1.Controls.Add(this.lblComicBookTitle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(26, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 195);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(210, 68);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(46, 20);
            this.txtLast.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Last Issue";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirst.Location = new System.Drawing.Point(79, 68);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(46, 20);
            this.txtFirst.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "First Issue";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.txtLastMod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFirstMod);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNumOfSpIssues2);
            this.groupBox2.Controls.Add(this.txtNumOfIssues2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtComicTitle2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Location = new System.Drawing.Point(26, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 191);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // txtLastMod
            // 
            this.txtLastMod.Location = new System.Drawing.Point(210, 47);
            this.txtLastMod.Name = "txtLastMod";
            this.txtLastMod.Size = new System.Drawing.Size(46, 20);
            this.txtLastMod.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Last Issue";
            // 
            // txtFirstMod
            // 
            this.txtFirstMod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirstMod.Location = new System.Drawing.Point(79, 50);
            this.txtFirstMod.Name = "txtFirstMod";
            this.txtFirstMod.ReadOnly = true;
            this.txtFirstMod.Size = new System.Drawing.Size(46, 20);
            this.txtFirstMod.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "First Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 20);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // txtShowAll
            // 
            this.txtShowAll.Location = new System.Drawing.Point(170, 64);
            this.txtShowAll.Name = "txtShowAll";
            this.txtShowAll.Size = new System.Drawing.Size(112, 20);
            this.txtShowAll.TabIndex = 15;
            this.txtShowAll.Text = "Show All Titles";
            this.txtShowAll.UseVisualStyleBackColor = true;
            this.txtShowAll.Click += new System.EventHandler(this.txtShowAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtShowAll);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(24, 470);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 97);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(153, 20);
            this.backupToolStripMenuItem1.Text = "Backup to Thumb Drive";
            this.backupToolStripMenuItem1.ToolTipText = "Backup the database files to a thumb drive; will take \r\nthe most recent backup (m" +
                "idnight of current date)";
            this.backupToolStripMenuItem1.Click += new System.EventHandler(this.backupToolStripMenuItem1_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // firstIssueDataGridViewTextBoxColumn
            // 
            this.firstIssueDataGridViewTextBoxColumn.DataPropertyName = "FirstIssue";
            this.firstIssueDataGridViewTextBoxColumn.HeaderText = "First Issue";
            this.firstIssueDataGridViewTextBoxColumn.Name = "firstIssueDataGridViewTextBoxColumn";
            this.firstIssueDataGridViewTextBoxColumn.Width = 73;
            // 
            // lastIssueDataGridViewTextBoxColumn
            // 
            this.lastIssueDataGridViewTextBoxColumn.DataPropertyName = "LastIssue";
            this.lastIssueDataGridViewTextBoxColumn.HeaderText = "Last Issue";
            this.lastIssueDataGridViewTextBoxColumn.Name = "lastIssueDataGridViewTextBoxColumn";
            this.lastIssueDataGridViewTextBoxColumn.Width = 74;
            // 
            // numIssuesDataGridViewTextBoxColumn
            // 
            this.numIssuesDataGridViewTextBoxColumn.DataPropertyName = "NumIssues";
            this.numIssuesDataGridViewTextBoxColumn.HeaderText = "Number of Issues";
            this.numIssuesDataGridViewTextBoxColumn.Name = "numIssuesDataGridViewTextBoxColumn";
            this.numIssuesDataGridViewTextBoxColumn.Width = 78;
            // 
            // numSpIssuesDataGridViewTextBoxColumn
            // 
            this.numSpIssuesDataGridViewTextBoxColumn.DataPropertyName = "NumSpIssues";
            this.numSpIssuesDataGridViewTextBoxColumn.HeaderText = "Number of Special Issues";
            this.numSpIssuesDataGridViewTextBoxColumn.Name = "numSpIssuesDataGridViewTextBoxColumn";
            this.numSpIssuesDataGridViewTextBoxColumn.Width = 112;
            // 
            // comicBookTitleBindingSource
            // 
            this.comicBookTitleBindingSource.DataMember = "ComicBookTitle";
            this.comicBookTitleBindingSource.DataSource = this.comicBookDataSet;
            // 
            // comicBookDataSet
            // 
            this.comicBookDataSet.DataSetName = "ComicBookDataSet";
            this.comicBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comicBookTitleTableAdapter
            // 
            this.comicBookTitleTableAdapter.ClearBeforeFill = true;
            // 
            // Titles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(958, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Titles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comic Book Organizer";
            this.Load += new System.EventHandler(this.Titles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookTitleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comicBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myWantListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOwnListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtNumOfSpIssues2;
        private System.Windows.Forms.TextBox txtNumOfIssues2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComicTitle2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComicBookTitle;
        private System.Windows.Forms.TextBox txtComicBookTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumOfSpecialIssues;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Button txtShowAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLastMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label10;
        private ComicBookDataSet comicBookDataSet;
        private System.Windows.Forms.BindingSource comicBookTitleBindingSource;
        private Comics.ComicBookDataSetTableAdapters.ComicBookTitleTableAdapter comicBookTitleTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupAllToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastIssueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIssuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSpIssuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem numberOwnedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;
    }
}

