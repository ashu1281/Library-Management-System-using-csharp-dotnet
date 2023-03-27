using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?", "Alert",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();
                Dashboard.memRestrict = 0;
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtContactNum.Clear();
            txtEmilid.Clear();
            txtstateName.Clear();
            txtcityName.Clear();
            txtpinCode.Clear(); //or txtpinCode.Text = "";
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text != "" && txtContactNum.Text != "" && txtEmilid.Text != "" && txtstateName.Text != "" && txtcityName.Text != "" && txtpinCode.Text != "")
            {

                String name = txtFullName.Text;
                Int64 contact = Int64.Parse(txtContactNum.Text);
                String email = txtEmilid.Text;
                String state = txtstateName.Text;
                String city = txtcityName.Text;
                Int64 pincode = Int64.Parse(txtpinCode.Text);

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";

                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection= conn;

                conn.Open();
                cmd.CommandText = "insert into NewMember (mName,mContact,mEmail,mState,mCity,mPinCode) values ('" + name + "'," + contact + ",'" + email + "','" + state + "','" + city + "',"+pincode+")";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Saved.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
