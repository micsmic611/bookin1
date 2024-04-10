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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupcusto sgcut = new signupcusto();
            sgcut.Show();
        }

        private void signupp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signupcusto sgcut = new signupcusto();
            sgcut.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            equipborken eqb = new equipborken();
            eqb.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            meetroom mtr = new meetroom();
            mtr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            meetroom mtr = new meetroom();
            mtr.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            equipborken eqb = new equipborken();
            eqb.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            information inf = new information();
            inf.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            information inf = new information();
            inf.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer cus = new customer();
            cus.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            customer cus = new customer();
            cus.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            notify noti = new notify();
            noti.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            notify noti = new notify();
            noti.Show();
        }
    }
}
