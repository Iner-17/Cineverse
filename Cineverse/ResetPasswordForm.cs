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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_newPass.UseSystemPasswordChar == false)
            {
                btn_hide.BringToFront();
                txt_newPass.UseSystemPasswordChar = true;
            }
            btn_show.BackColor = Color.Black;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_newPass.UseSystemPasswordChar == true)
            {
                btn_show.BringToFront();
                txt_newPass.UseSystemPasswordChar = false;
            }
            btn_hide.BackColor = Color.Black;
        }

        private void btn_confirmShow_Click(object sender, EventArgs e)
        {
            if (txt_confirmPass.UseSystemPasswordChar == false)
            {
                btn_confirmHide.BringToFront();
                txt_confirmPass.UseSystemPasswordChar = true;
            }
            btn_confirmShow.BackColor = Color.Black;
        }

        private void btn_confirmHide_Click(object sender, EventArgs e)
        {
            if (txt_confirmPass.UseSystemPasswordChar == true)
            {
                btn_confirmShow.BringToFront();
                txt_confirmPass.UseSystemPasswordChar = false;
            }
            btn_confirmHide.BackColor = Color.Black;

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
