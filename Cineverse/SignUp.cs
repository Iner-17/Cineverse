using ExpenseApp;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
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
                lbl_astEmail.Text = "*";
                txt_email.ForeColor = Color.Silver;
            }

            string email = txt_email.Text;

            Regex regex = new Regex(@"^[\w!#$%&'+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)"
                           + "@"
                           + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            Match match = regex.Match(email);
            if (match.Success && txt_email.BorderColor == Color.Red)
            {
                txt_email.BorderColor = Color.White;
            } 
            


            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string checkDupliQuery = "SELECT * FROM accounts WHERE email=@Email";
                MySqlCommand cmd = new MySqlCommand(checkDupliQuery, conn);
                cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Email Already Exists.");
                    txt_email.Text = "Email";
                    txt_email.ForeColor = Color.Silver;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

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

            if (!txt_ContactNum.Text.StartsWith("09"))
            {
                MessageBox.Show("Contact Number should start with 09");
                txt_ContactNum.Text = "Contact No.";
            }

            if (txt_ContactNum.TextLength != 11)
            {
                MessageBox.Show("Number should be a minimum of 11 digits.");
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

   

        public void signUp()
        {
            MySqlConnection conn = DBConnection.getConnection();
            string firstNamePlaceholder = "First Name";
            string lastNamePlaceholder = "Last Name";
            string emailPlaceholder = "Email";
            string contactPlaceholder = "Contact No.";
            string usernamePlaceholder = "Username";
            string passwordPlaceholder = "Password";
            string confirmPlaceholder = "Confirm Password";


            if (txt_firstName.Text == "First Name" || txt_lastName.Text == "Last Name" || txt_ContactNum.Text == "Contact No." || txt_email.Text == "Email" || txt_username.Text == "Username" || txt_password.Text == "Password" || txt_confirmPassword.Text == "Confirm Password")
            {
                

                string firstNameInput = txt_firstName.Text.Trim();
                if (string.IsNullOrEmpty(firstNameInput) || firstNameInput == firstNamePlaceholder)
                {
                    txt_firstName.BorderColor = Color.Red;
                    ep_FN.SetError(txt_firstName, "What's your First Name?");
                }
                else
                {
                    ep_FN.SetError(txt_firstName, string.Empty);
                }

                string lasttNameInput = txt_lastName.Text.Trim();
                if (string.IsNullOrEmpty(lasttNameInput) || lasttNameInput == lastNamePlaceholder)
                {
                    txt_lastName.BorderColor = Color.Red;
                    ep_FN.SetError(txt_lastName, "What's your Last Name?");
                }
                else
                {
                    ep_FN.SetError(txt_lastName, string.Empty);
                }

                string emailInput = txt_email.Text.Trim();
                if (string.IsNullOrEmpty(emailInput) || emailInput == emailPlaceholder)
                {
                    txt_email.BorderColor = Color.Red;
                    ep_FN.SetError(txt_email, "You'll use this when you log in and if you need to reset your Password.");
                }
                else
                {
                    ep_FN.SetError(txt_email, string.Empty);
                }

                string contactInput = txt_ContactNum.Text.Trim();
                if (string.IsNullOrEmpty(contactInput) || contactInput == contactPlaceholder)
                {
                    txt_ContactNum.BorderColor = Color.Red;
                    ep_FN.SetError(txt_ContactNum, "What's your Phone Number?");
                }
                else
                {
                    ep_FN.SetError(txt_ContactNum, string.Empty);
                }

                string usernameInput = txt_username.Text.Trim();
                if (string.IsNullOrEmpty(usernameInput) || usernameInput == usernamePlaceholder)
                {
                    txt_username.BorderColor = Color.Red;
                    ep_FN.SetError(txt_username, "You'll use this when you log in.");
                }
                else
                {
                    ep_FN.SetError(txt_username, string.Empty);
                }

                string passwordInput = txt_password.Text.Trim();
                if (string.IsNullOrEmpty(passwordInput) || passwordInput == passwordPlaceholder)
                {
                    txt_password.BorderColor = Color.Red;
                    ep_FN.SetError(txt_password, "Enter a combination of atleast 8 characters, letters, and symbols");
                }
                else
                {
                    ep_FN.SetError(txt_password, string.Empty);
                }

                string confirmpasswordInput = txt_confirmPassword.Text.Trim();
                if (string.IsNullOrEmpty(confirmpasswordInput) || confirmpasswordInput == confirmPlaceholder)
                {
                    txt_confirmPassword.BorderColor = Color.Red;
                    ep_FN.SetError(txt_confirmPassword, "Password and Confirm Password must be the same");
                }
                else
                {
                    ep_FN.SetError(txt_confirmPassword, string.Empty);
                }
            }
            else if (txt_firstName.TextLength < 2)
            {
                MessageBox.Show("First Name should have at least 2 characters.");
            }
            else if (txt_lastName.TextLength < 2)
            {
                MessageBox.Show("Last Name should have at least 2 characters.");
            }
            else if (txt_confirmPassword.Text != txt_password.Text)
            {
                MessageBox.Show("Unmatched Password");
                txt_confirmPassword.BorderColor = Color.Red;
            }
            else if (!txt_ContactNum.Text.StartsWith("09"))
            {
                MessageBox.Show("Contact Number should start with 09");
                txt_ContactNum.Text = "Contact No.";
            }
            else if (txt_ContactNum.TextLength != 11)
            {
                MessageBox.Show("Number should be a minimum of 11 digits.");
            }
           
            else
            {
                if (IsValidPassword(txt_password.Text))
                {
                    txt_password.BorderColor = Color.White;

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

                            string password = Security.Encrypt(txt_password.Text);

                            string signupQuery = "INSERT INTO accounts (firstname, lastname, email, username, password, phone_number) VALUES (@Firstname, @Lastname, @Email, @Username, @Password, @PhoneNumber);";
                            MySqlCommand signupcmd = new MySqlCommand(signupQuery, conn);
                            signupcmd.Parameters.AddWithValue("@Firstname", txt_firstName.Text);
                            signupcmd.Parameters.AddWithValue("@Lastname", txt_lastName.Text);
                            signupcmd.Parameters.AddWithValue("@Email", txt_email.Text);
                            signupcmd.Parameters.AddWithValue("@Username", txt_username.Text);
                            signupcmd.Parameters.AddWithValue("@Password", password);
                            signupcmd.Parameters.AddWithValue("@PhoneNumber", txt_ContactNum.Text);
                            signupcmd.ExecuteNonQuery();

                            MessageBox.Show("Successfully Added Account");

                            txt_firstName.Text = "First Name";
                            txt_lastName.Text = "Last Name";
                            txt_email.Text = "Email";
                            txt_ContactNum.Text = "Contact No.";
                            txt_username.Text = "Username";
                            txt_password.UseSystemPasswordChar = false;
                            txt_confirmPassword.UseSystemPasswordChar = false;

                            txt_password.Text = "Password";
                            txt_confirmPassword.Text = "Confirm Password";
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
                    MessageBox.Show("Password should have atleast 8 characters, 1 number, and 1 symbol.");
                    txt_password.BorderColor = Color.Red;
                }
               
            }

            Login login = new Login();
            login.Show();
            this.Close();
        }

        static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            var isValidated = hasNumber.IsMatch(password) && hasMinimum8Chars.IsMatch(password) && hasSymbols.IsMatch(password);
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
                e.Handled = true;
            }

            if (txt_ContactNum.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;
                txt_ContactNum.BorderColor = Color.White;

            }

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {
            string firstNameInput = txt_firstName.Text.Trim();


            if (!string.IsNullOrEmpty(firstNameInput) && firstNameInput != "First Name")
            {
                txt_firstName.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_firstName, string.Empty);
            }
        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {
            string lastNameInput = txt_lastName.Text.Trim();


            if (!string.IsNullOrEmpty(lastNameInput) && lastNameInput != "Last Name")
            {
                txt_lastName.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_lastName, string.Empty);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            string emailInput = txt_email.Text.Trim();


            if (!string.IsNullOrEmpty(emailInput) && emailInput != "Email")
            {
                txt_email.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_email, string.Empty);
            }
        }

        private void txt_ContactNum_TextChanged(object sender, EventArgs e)
        {
            string contactInput = txt_ContactNum.Text.Trim();


            if (!string.IsNullOrEmpty(contactInput) && contactInput != "Contact No.")
            {
                txt_ContactNum.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_ContactNum, string.Empty);
            }
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            string usernameInput = txt_username.Text.Trim();


            if (!string.IsNullOrEmpty(usernameInput) && usernameInput != "Username")
            {
                txt_username.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_username, string.Empty);
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            string passwordInput = txt_password.Text.Trim();


            if (!string.IsNullOrEmpty(passwordInput) && passwordInput != "Password")
            {
                txt_password.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_password, string.Empty);
            }
        }

        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {
            string confirmInput = txt_confirmPassword.Text.Trim();


            if (!string.IsNullOrEmpty(confirmInput) && confirmInput != "Confirm Password")
            {
                txt_confirmPassword.BorderColor = SystemColors.ControlDark;
                ep_FN.SetError(txt_confirmPassword, string.Empty);
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                // Suppress the space character
                e.Handled = true;
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                // Suppress the space character
                e.Handled = true;
            }
        }
    }
}