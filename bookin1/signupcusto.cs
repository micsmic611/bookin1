using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookin1
{
    public partial class signupcusto : Form
    {
        public signupcusto()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void mainn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }
        Booking_AppEntities2 db = new Booking_AppEntities2();
        private void Submit_Click(object sender, EventArgs e)
        {
            if (Fname.Text != "" &&Lname.Text != "" && Tel.Text != "" && dateTimePicker1.Text != "" && Emaill.Text != ""
               && Usname.Text != "" && txtpassword.Text != "")
            {
                if (txtpassword.Text != "")
                {

                    signup s = new signup();
                    s.User_Username = Usname.Text.Trim();
                    s.User_Password = txtpassword.Text.Trim();
                    s.User_Name = Fname.Text.Trim();
                    s.User_Lastname = Lname.Text.Trim();
                    s.User_Tel = Tel.Text.Trim();
                    s.User_Email = Emaill.Text.Trim();
                    s.User_Password = txtpassword.Text.Trim();
                    db.signup.Add(s);
                    db.SaveChanges();
                    


                    MessageBox.Show("ลงทะเบียนเสร็จสิ้น <3");  
                }
                else
                {
                    MessageBox.Show("Password ไม่ตรงกัน");
                }


            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
