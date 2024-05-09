using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                lbl_astFN.Text = "";
                txt_firstName.Text = "";
                txt_firstName.ForeColor = Color.White;
            }

            txt_firstName.BorderColor = Color.White;
        }

        private void txt_firstName_Leave(object sender, EventArgs e)
        {
            if (txt_firstName.Text == "")
            {
                txt_firstName.Text = "First Name";
                lbl_astFN.Text = "*";
                txt_firstName.ForeColor = Color.Silver;
            }
        }

        private void txt_lastName_Enter(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "Last Name")
            {
                lbl_astLN.Text = "";
                txt_lastName.Text = "";
                txt_lastName.ForeColor = Color.White;
            }

            txt_lastName.BorderColor = Color.White;
        }

        private void txt_lastName_Leave(object sender, EventArgs e)
        {
            if (txt_lastName.Text == "")
            {
                txt_lastName.Text = "Last Name";
                lbl_astLN.Text = "*";
                txt_lastName.ForeColor = Color.Silver;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "Email")
            {
                lbl_astEmail.Text = "";
                txt_email.Text = "";
                txt_email.ForeColor = Color.White;
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "Email";
                lbl_astEmail.Text= "*";
                txt_email.ForeColor = Color.Silver;
            }

            string email = txt_email.Text;

            Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                           + "@"
                           + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            Match match = regex.Match(email);
            if (match.Success && txt_email.BorderColor == Color.Red)
            {
                txt_email.BorderColor = Color.White;
            }
        }


        private void txt_ContactNum_Enter(object sender, EventArgs e)
        {
            if (txt_ContactNum.Text == "Contact No.")
            {
                lbl_astContactNo.Text = "";
                txt_ContactNum.Text = "";
                txt_ContactNum.ForeColor = Color.White;
            }

        }

        private void txt_ContactNum_Leave(object sender, EventArgs e)
        {
            if (txt_ContactNum.Text == "")
            {
                txt_ContactNum.Text = "Contact No.";
                lbl_astContactNo.Text = "*";
                txt_ContactNum.ForeColor = Color.Silver;
            }
            

        }
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                lbl_astUsername.Text = "";
                txt_username.Text = "";
                txt_username.ForeColor = Color.White;
            }

            txt_username.BorderColor = Color.White;
        }

        private void txt_username_Leave_1(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                lbl_astUsername.Text = "*";
                txt_username.ForeColor = Color.Silver;
            }

            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string checkDupliQuery = "SELECT * FROM accounts WHERE username=@Username";
                MySqlCommand cmd = new MySqlCommand(checkDupliQuery, conn);
                cmd.Parameters.AddWithValue("@Username", txt_username.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows)
                {
                    MessageBox.Show("Username Already Exists.");
                    txt_username.Text = "Username*";
                    txt_username.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                lbl_astPass.Text = "";
                txt_password.ForeColor = Color.White;
                if (txt_password.UseSystemPasswordChar == false)
                {
                    txt_password.UseSystemPasswordChar = true;
                } 
            }

            txt_password.BorderColor = Color.White;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                lbl_astPass.Text = "*";
                txt_password.ForeColor = Color.Silver;
                if (txt_password.UseSystemPasswordChar == true)
                {
                    txt_password.UseSystemPasswordChar = false;
                }
            }


            if (IsValidPassword(txt_password.Text))
            {
                txt_password.BorderColor = Color.White;
                
            } else
            {
                MessageBox.Show("Password should have atleast 8 characters, 1 number, 1 symbol, and 1 capital letter.");
                txt_password.BorderColor = Color.Red;
            }
        }

        private void txt_confirmPassword_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "Confirm Password")
            {
                txt_confirmPassword.Text = "";
                lbl_astConfirmPass.Text = "";
                txt_confirmPassword.ForeColor = Color.White;
                if (txt_confirmPassword.UseSystemPasswordChar == false)
                {
                    txt_confirmPassword.UseSystemPasswordChar = true;
                }
            }
            txt_confirmPassword.BorderColor = Color.White;

        }

        private void txt_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "")
            {
                txt_confirmPassword.Text = "Confirm Password";
                lbl_astConfirmPass.Text = "*";
                txt_confirmPassword.ForeColor = Color.Silver;
                if (txt_confirmPassword.UseSystemPasswordChar == true)
                {
                    txt_confirmPassword.UseSystemPasswordChar = false;
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private void signUp()
        {
            MySqlConnection conn = DBConnection.getConnection();


            if (txt_firstName.Text != "First Name*" && txt_lastName.Text != "Last Name*" && txt_email.Text != "Email*" && txt_username.Text != "Username*" && txt_password.Text != "Password" && txt_confirmPassword.Text != "Confirm Password")
            {
                if (txt_firstName.Text.Length > 2 || txt_username.Text.Length > 2)
                {
                    if (txt_confirmPassword.Text == txt_password.Text)
                    {
                        string email = txt_email.Text;
                        Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                            + "@"
                            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                        Match match = regex.Match(email);
                        if (match.Success)
                        {
                            try
                            {
                                conn.Open();

                                string signupQuery = "INSERT INTO accounts (firstname, lastname, email, username, password, phone_number) VALUES (@Firstname, @Lastname, @Email, @Username, @Password, @PhoneNumber);";
                                MySqlCommand signupcmd = new MySqlCommand(signupQuery, conn);
                                signupcmd.Parameters.AddWithValue("@Firstname", txt_firstName.Text);
                                signupcmd.Parameters.AddWithValue("@Lastname", txt_lastName.Text);
                                signupcmd.Parameters.AddWithValue("@Email", txt_email.Text);
                                signupcmd.Parameters.AddWithValue("@Username", txt_username.Text);
                                signupcmd.Parameters.AddWithValue("@Password", txt_password.Text);
                                signupcmd.Parameters.AddWithValue("@PhoneNumber", txt_ContactNum.Text);
                                signupcmd.ExecuteNonQuery();

                                MessageBox.Show("Successfully Added Account");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally { conn.Close(); }
                        }
                        else
                        {
                            MessageBox.Show(email + " is not a valid email.");
                            txt_email.BorderColor = Color.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unmatched Password");
                        txt_confirmPassword.BorderColor = Color.Red;
                    }
                } else
                {
                    MessageBox.Show("First Name should have atleast 3 character.");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
                if (txt_firstName.Text.Equals("First Name"))
                {
                    txt_firstName.BorderColor = Color.Red;
                }
                if (txt_lastName.Text.Equals("Last Name"))
                {
                    txt_lastName.BorderColor = Color.Red;
                }
                if (txt_email.Text.Equals("Email"))
                {
                    txt_email.BorderColor = Color.Red;
                }
                if (txt_username.Text.Equals("Username"))
                {
                    txt_username.BorderColor = Color.Red;
                }
                if (txt_password.Text.Equals("Password"))
                {
                    txt_password.BorderColor = Color.Red;
                }
                if (txt_confirmPassword.Text.Equals("Confirm Password"))
                {
                    txt_confirmPassword.BorderColor = Color.Red;
                }
                if (txt_ContactNum.Text.Equals("Contact No."))
                {
                    txt_ContactNum.BorderColor = Color.Red;
                }


            }
        }

        static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password) && hasSymbols.IsMatch(password);
            return isValidated;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(188, 0, 0, 0);
        }

        private void txt_ContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the key is not a digit or Backspace, ignore it by setting Handled to true
                e.Handled = true;
            }

            // Check if the length of the text is already 11 and the pressed key is not Backspace
            if (txt_ContactNum.Text.Length >= 11 && e.KeyChar != '\b')
            {
                // If the text length is already 11 and the key is not Backspace, ignore it by setting Handled to true
                e.Handled = true;
                txt_ContactNum.BorderColor = Color.White;

            }

        }
    }
}