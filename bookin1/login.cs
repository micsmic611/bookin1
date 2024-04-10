using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

namespace bookin1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void login1_Click(object sender, EventArgs e)
        {
            string U = txtusername.Text;
            string P = txtpassword.Text;
            if (txtusername.Text == "")
            {
                txtusername.Clear();
                MessageBox.Show("enter username");
            }
            else if (txtpassword.Text == "")
            {
                txtpassword.Clear();
                MessageBox.Show("enter password");

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=CIM611;Initial Catalog=Booking_App;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from dbo.signup where User_Username = @User_Username and User_Password = @User_Password ", con);
                    cmd.Parameters.AddWithValue("@User_Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@User_Password", txtpassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                  
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        main main = new main();
                        main.Show();
                    }
                    else
                    {
                        txtusername.Clear();
                        txtpassword.Clear();
                        MessageBox.Show("username or password is invalid");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
