using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System
{
    public partial class Return_Book : Form
    {
        public Return_Book()
        {
            InitializeComponent();
        }

        

        

        

        private void Return_Book_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string enroll = txtsearchEnroll.Text;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection= conn;

            cmd.CommandText = "select EnrollID,Member_Name,Book_Name,Book_Issue_Date,Book_Return_Date from IssueReturnBook where EnrollID= '" + enroll + "' and Book_Return_Date is Null";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("This Enrollment Number does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        string enrollid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {


                enrollid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                
                panel3.Visible = true;

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from IssueReturnBook where EnrollID = '" + enrollid + "' and Book_Return_Date is Null";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);



                rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                txtEnrollID.Text = ds.Tables[0].Rows[0][1].ToString();
                txtMemberName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtContact.Text = ds.Tables[0].Rows[0][3].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][4].ToString();
                txtBookName.Text = ds.Tables[0].Rows[0][5].ToString();
                txtIssueDate.Text = ds.Tables[0].Rows[0][6].ToString();

            }
        }

        private void txtsearchEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchEnroll.Text == "")
            {
                dataGridView1.DataSource = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtsearchEnroll.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panel3.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String enroll = txtsearchEnroll.Text;
            String rtdate = ReturnDateTimePicker1.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            conn.Open();

            cmd.CommandText = "update IssueReturnBook SET Book_Return_Date = '"+rtdate+"' WHERE ID="+rowid+"";
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Book Return Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select EnrollID,Member_Name,Book_Name,Book_Issue_Date,Book_Return_Date from IssueReturnBook where EnrollID= '" + enroll + "' and Book_Return_Date is Null";

            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);

            if (ds1.Tables[0].Rows.Count != 0)
            {

                dataGridView1.DataSource = ds1.Tables[0];
            }

            panel3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
