using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

      


        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
           // label5.BackColor = System.Drawing.Color.Transparent;
            
            pictureBox1.BackColor = System.Drawing.Color.Transparent;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";
            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = conn;

            cmd.CommandText = "SELECT TOP 3 Book_Name, COUNT(*) AS count FROM IssueReturnBook GROUP BY Book_Name ORDER BY count DESC ";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                BooksdataGridView.DataSource = ds.Tables[0];
                BooksdataGridView.Columns.Clear();
                BooksdataGridView.Columns.Add("serialNumber", "Rank");
                BooksdataGridView.Columns.Add("Book_Name", "Book Name");
                BooksdataGridView.Columns.Add("count", "Read Count");
                BooksdataGridView.Columns[0].Width = 60;
                BooksdataGridView.Columns[1].DataPropertyName = "Book_Name";
                BooksdataGridView.Columns[1].Width = 200;
                BooksdataGridView.Columns[2].DataPropertyName = "count";

            }
            
            cmd.CommandText = "SELECT TOP 3 Member_Name, COUNT(*) AS count FROM IssueReturnBook where Book_Return_Date is not null GROUP BY Member_Name ORDER BY count DESC ";

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count != 0)
            {
                MemberdataGridView.DataSource = ds1.Tables[0];
                MemberdataGridView.Columns.Clear();
                MemberdataGridView.Columns.Add("serialNumber", "Rank");
                MemberdataGridView.Columns.Add("Member_Name", "Member Name");
                MemberdataGridView.Columns.Add("count", "No. of Readed Books");
                MemberdataGridView.Columns[1].DataPropertyName = "Member_Name";
                MemberdataGridView.Columns[2].DataPropertyName = "count";
                MemberdataGridView.Columns[0].Width = 60;
                MemberdataGridView.Columns[1].Width = 200;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public static int restrict = 0;
        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(restrict == 0)
            {
                restrict++;
                AddBooks abs = new AddBooks();
                abs.Show();
                abs.TopMost= true;
            }
            else
            {
                MessageBox.Show("Add New Books Form is already opened!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }


        public static int memRestrict = 0;
        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(memRestrict == 0)
            {

                AddMember addMember = new AddMember();
                addMember.Show();
                memRestrict++;
            }
            else
            {
                MessageBox.Show("Form is already Opened.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMember vm = new ViewMember();
            vm.Show();
        }

        public static int issueBookRestrict = 0;
        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(issueBookRestrict == 0)
            {
                issueBookRestrict++;
                IssueBook ib = new IssueBook();
                ib.Show();
                //ib.TopMost = true;
            }
            else
            {
                MessageBox.Show("Form is already Opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Book rb = new Return_Book();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }


        private void BooksdataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if(e.RowIndex < 3)
            {
                DataGridViewRow row = BooksdataGridView.Rows[e.RowIndex];
                row.Cells["serialNumber"].Value = (e.RowIndex + 1).ToString();
            }
              
        }

        private void MemberdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if(e.RowIndex < 3)
            {
                DataGridViewRow row = MemberdataGridView.Rows[e.RowIndex];
                row.Cells["serialNumber"].Value = (e.RowIndex + 1).ToString();
            }
        }

        private void BooksdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            Dashboard_Load(sender, e);
        }

        private void listOfReadedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listofReadedBooks lrb = new listofReadedBooks();
            lrb.Show();
        }

        private void listOfMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListofMembers lm = new ListofMembers();
            lm.Show();
        }
    }
}
