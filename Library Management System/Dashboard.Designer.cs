namespace Library_Management_System
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfReadedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BooksdataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MemberdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Ivory;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.toolStripMenuItem1,
            this.completeBookDetailsToolStripMenuItem,
            this.listOfReadedToolStripMenuItem,
            this.listOfMembersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1760, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.booksToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_books_50;
            this.booksToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(113, 54);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_add_book_48;
            this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.addNewBookToolStripMenuItem.Text = "Add New Book";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_view_50;
            this.viewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(254, 56);
            this.viewBookToolStripMenuItem.Text = "View Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.studentsToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_student_male_50;
            this.studentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(129, 54);
            this.studentsToolStripMenuItem.Text = "Member";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_student_male_1000;
            this.addMemberToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(294, 106);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_view_501;
            this.viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(294, 106);
            this.viewToolStripMenuItem.Text = "View Member Info";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewMemberToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_book_philosophy_50;
            this.issueBookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issueBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(143, 54);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolStripMenuItem1.Image = global::Library_Management_System.Properties.Resources.icons8_return_book_50;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 54);
            this.toolStripMenuItem1.Text = "Return Book";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            this.completeBookDetailsToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_books_501;
            this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(226, 54);
            this.completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            this.completeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.completeBookDetailsToolStripMenuItem_Click);
            // 
            // listOfReadedToolStripMenuItem
            // 
            this.listOfReadedToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.listOfReadedToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.bookslists2;
            this.listOfReadedToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listOfReadedToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listOfReadedToolStripMenuItem.Name = "listOfReadedToolStripMenuItem";
            this.listOfReadedToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listOfReadedToolStripMenuItem.Size = new System.Drawing.Size(220, 54);
            this.listOfReadedToolStripMenuItem.Text = "Llist  of Readed Books";
            this.listOfReadedToolStripMenuItem.Click += new System.EventHandler(this.listOfReadedToolStripMenuItem_Click);
            // 
            // listOfMembersToolStripMenuItem
            // 
            this.listOfMembersToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.member_group;
            this.listOfMembersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listOfMembersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listOfMembersToolStripMenuItem.Name = "listOfMembersToolStripMenuItem";
            this.listOfMembersToolStripMenuItem.Size = new System.Drawing.Size(183, 54);
            this.listOfMembersToolStripMenuItem.Text = "List of Members ";
            this.listOfMembersToolStripMenuItem.Click += new System.EventHandler(this.listOfMembersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.exitToolStripMenuItem.Image = global::Library_Management_System.Properties.Resources.icons8_exit_sign_50;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(355, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trending Now";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumOrchid;
            this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.hashtag_trending;
            this.pictureBox1.Location = new System.Drawing.Point(718, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 3 Most Popular Books ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BooksdataGridView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(367, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 313);
            this.panel1.TabIndex = 4;
            // 
            // BooksdataGridView
            // 
            this.BooksdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BooksdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BooksdataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BooksdataGridView.Location = new System.Drawing.Point(26, 57);
            this.BooksdataGridView.Name = "BooksdataGridView";
            this.BooksdataGridView.RowHeadersWidth = 51;
            this.BooksdataGridView.RowTemplate.Height = 24;
            this.BooksdataGridView.Size = new System.Drawing.Size(534, 239);
            this.BooksdataGridView.TabIndex = 4;
            this.BooksdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksdataGridView_CellContentClick);
            this.BooksdataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.BooksdataGridView1_RowPostPaint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(231, -318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 68);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trending Now";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MemberdataGridView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1039, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 313);
            this.panel2.TabIndex = 5;
            // 
            // MemberdataGridView
            // 
            this.MemberdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.MemberdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberdataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.MemberdataGridView.Location = new System.Drawing.Point(26, 57);
            this.MemberdataGridView.Name = "MemberdataGridView";
            this.MemberdataGridView.RowHeadersWidth = 51;
            this.MemberdataGridView.RowTemplate.Height = 24;
            this.MemberdataGridView.Size = new System.Drawing.Size(521, 239);
            this.MemberdataGridView.TabIndex = 5;
            this.MemberdataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.MemberdataGridView_RowPostPaint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Top 3 Members";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT Black", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(601, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(783, 93);
            this.label5.TabIndex = 6;
            this.label5.Text = "Admin Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Library_Management_System.Properties.Resources.Dashboardnew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1760, 966);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksdataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView BooksdataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView MemberdataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem listOfReadedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label5;
    }
}