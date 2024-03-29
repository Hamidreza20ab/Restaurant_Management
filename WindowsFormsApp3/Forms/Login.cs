using Restaurant_Management.DataLayer;
using Restaurant_Management.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(23, 24, 35);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RS_Model db = new RS_Model();
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("لطفا نام کاربری یا رمز عبور را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (db.Users.Any(u => u.UserName == txtUserName.Text && u.Password == txtPass.Text))
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.Dispose();


        }

        private void LoginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = LoginShowPassword.Checked ? '\0' : '*';
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
