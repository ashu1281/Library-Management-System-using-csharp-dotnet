using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void vewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Application.Exit();
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
    }
}
