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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String bpublication = txtPublication.Text;
                String bpubDate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(txtPrice.Text);
                Int64 bquantity = Int64.Parse(txtQuantity.Text);

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";
                //conn.ConnectionString = "data source = localhost\\sqlexpress; database = LibraryManagement;integrated security=True";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into NewBook (bName, bAuthor, bPubl, bPubDate, bPrice, bQuan) values ('" + bname + "','" + bauthor + "','" + bpublication + "','" + bpubDate + "','" + bprice + "','" + bquantity + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAddBookCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE your Unsaved DATA", "Are you Sure?",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();
            }
            Dashboard.restrict = 0;
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            //dateTimePicker1.
            
        }
    }
}
