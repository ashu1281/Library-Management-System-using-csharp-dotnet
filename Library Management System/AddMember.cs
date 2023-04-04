using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            }
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtContactNum.Clear();
            txtEmilid.Clear();
            txtcityName.Clear();
            txtpinCode.Clear(); //or txtpinCode.Text = "";

            combostate.SelectedItem = null;
            

        }
        private byte[] ImageToByteArray(string imagePath)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                byte[] imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
                return imageData;
            }
        }


        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text != "" && txtContactNum.Text != "" && txtEmilid.Text != "" && combostate.Text != "" && txtcityName.Text != "" && txtpinCode.Text != "")
            {
                

                // Check if an image was chosen
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Convert the image to a byte array
                    byte[] imageData = ImageToByteArray(imagePath);

                    // Get the user's personal information from text boxes or other controls
                    String name = txtFullName.Text;
                    String contact = txtContactNum.Text;
                    String email = txtEmilid.Text;
                    String state = combostate.Text;
                    String city = txtcityName.Text;
                    Int64 pincode = Int64.Parse(txtpinCode.Text);

                    // Create a connection to the database
                    SqlConnection connection = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");

                    // Open the database connection
                    connection.Open();

                    // Create a SQL command to insert the image data and personal information into one table
                   //// SqlCommand command = new SqlCommand("INSERT INTO MyTable (ImageData, FirstName, LastName, Email) VALUES (@ImageData, @FirstName, @LastName, @Email)", connection);

                    SqlCommand command = new SqlCommand("INSERT INTO NewMember (mName,mContact,mEmail,mState,mCity,mPinCode,mPhoto) VALUES (@mName, @mContact, @mEmail, @mState, @mCity, @mPinCode, @mPhoto)", connection);

                    // Add the image data and personal information parameters to the command
                    command.Parameters.AddWithValue("@mName", name);
                    command.Parameters.AddWithValue("@mContact", contact);
                    command.Parameters.AddWithValue("@mEmail", email);
                    command.Parameters.AddWithValue("@mState", state);
                    command.Parameters.AddWithValue("@mCity", city);
                    command.Parameters.AddWithValue("@mPinCode", pincode);
                    SqlParameter imageDataParameter = new SqlParameter("@mPhoto", SqlDbType.VarBinary);
                    imageDataParameter.Value = imageData;
                    command.Parameters.Add(imageDataParameter);

                    // Execute the SQL command
                    command.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 EnrollId FROM NewMember ORDER BY ID DESC", connection);
                    SqlDataReader dr = cmd2.ExecuteReader();

                    if (dr.Read())
                    {
                        string message = string.Format("Your UserID is: {0}", dr[0].ToString());

                        MessageBox.Show(message, "Data Saved Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dr.Close();


                    // Close the database connection
                    connection.Close();

                    // Display a message to the user that the data has been saved
                 
                }
                else
                {
                    // Display an error message if no image was chosen
                    MessageBox.Show("No image was chosen.");
                }



                //String name = txtFullName.Text;
                //String contact = txtContactNum.Text;
                //String email = txtEmilid.Text;
                //String state = combostate.Text;
                //String city = txtcityName.Text;
                //Int64 pincode = Int64.Parse(txtpinCode.Text);

                //String userId = string.Empty;

                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False";

                //SqlCommand cmd = conn.CreateCommand();
                //cmd.Connection= conn;

                //conn.Open();
                //cmd.CommandText = "insert into NewMember (mName,mContact,mEmail,mState,mCity,mPinCode,mPhoto) values ('" + name + "','" + contact + "','" + email + "','" + state + "','" + city + "',"+pincode+")";
                //cmd.ExecuteNonQuery();

                //SqlCommand cmd2 = new SqlCommand("SELECT TOP 1 EnrollId FROM NewMember ORDER BY ID DESC", conn);
                //SqlDataReader dr = cmd2.ExecuteReader();

                //if (dr.Read())
                //{
                //    string message = string.Format("Your UserID is: {0}", dr[0].ToString());

                //    MessageBox.Show(message,"Data Saved Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //dr.Close();


                //conn.Close();

                //MessageBox.Show("Data Saved.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields","Suggest",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        string imagePath = "";
        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               pictureBoxMember.Image = new Bitmap(openFileDialog.FileName);
               imagePath = openFileDialog.FileName;
            }
        }
    }
}
