using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cineverse
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        int otp;

        private void btn_sendCode_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            otp = random.Next(100000, 999999);


            MailMessage message = new MailMessage();
            message.From = new MailAddress("cineverse24@gmail.com");
            //email validation
            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
                        + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            Match match = regex.Match(txt_email.Text);
            if (match.Success)
            {
                message.To.Add(txt_email.Text);

            } else
            {
                MessageBox.Show("Invalid Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            message.Subject = "One Time Password (OTP)";
            message.Body = "Your OTP is: " + otp;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("cineverse24@gmail.com", "frcl afxf ckih thgx");
            smtp.EnableSsl = true;
            DateTime currentTime = DateTime.Now;

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP sent successfully");
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_code.Text.Equals(otp.ToString()))
            {
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
                resetPasswordForm.ShowDialog();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Incorrect OTP");
            }
        }
    }
}
