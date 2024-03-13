using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.ActiveControl = null;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void txt_firstName_Enter(object sender, EventArgs e)
        {
            
            if (txt_firstName.Text == "First Name")
            {
                txt_firstName.Text = "";
                txt_firstName.ForeColor = Color.White;
            }
        }

        private void txt_firstName_Leave(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "")
            {
                txt_firstName.Text = "First Name";
                txt_firstName.ForeColor = Color.Silver;
            }
        }

        private void txt_lastName_Enter(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "Last Name")
            {
                txt_lastName.Text = "";
                txt_lastName.ForeColor = Color.White;
            }
        }

        private void txt_lastName_Leave(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "")
            {
                txt_lastName.Text = "Last Name";
                txt_lastName.ForeColor = Color.Silver;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            this.Close();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email (Optional)")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.White;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email (Optional)";
                txt_email.ForeColor = Color.Silver;
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.White;
            }
        }

        private void txt_username_Leave_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.White;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
            }
        }

        private void txt_confirmPassword_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "Confirm Password")
            {
                txt_confirmPassword.Text = "";
                txt_confirmPassword.ForeColor = Color.White;
            }
        }

        private void txt_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "")
            {
                txt_confirmPassword.Text = "Confirm Password";
                txt_confirmPassword.ForeColor = Color.Silver;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.Show();
            this.Hide();
        }
    }
}