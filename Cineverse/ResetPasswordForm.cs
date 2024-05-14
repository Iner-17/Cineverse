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
            this.chk_showPass.CheckedChanged += new System.EventHandler(this.chk_showPass_CheckedChanged);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void chk_showPass_CheckedChanged(object sender, EventArgs e)
        {

                if (chk_showPass.Checked)
                {
                    txt_newPass.PasswordChar = '\0'; 
                    txt_confirmPass.PasswordChar = '\0'; // '\0' to show the password characters
                }
                else
                {
                    txt_newPass.PasswordChar = '●'; 
                    txt_confirmPass.PasswordChar = '●'; // '●' to hide the password characters
                }
        }

        private void chk_showPass_MouseEnter(object sender, EventArgs e)
        {
            chk_showPass.ClientRectangle.Contains(chk_showPass.PointToClient(Cursor.Position));
            
                chk_showPass.ForeColor = Color.FromArgb(31, 178, 198); 
                Font underlineFont = new Font(chk_showPass.Font, FontStyle.Underline); 
                chk_showPass.Font = underlineFont; // Apply the underline font
            
        }

        private void chk_showPass_MouseLeave(object sender, EventArgs e)
        {
            chk_showPass.ForeColor = SystemColors.Window; 
            chk_showPass.Font = new Font(chk_showPass.Font, FontStyle.Regular); // Remove underline
        }
    }
}
