using Cineverse;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Cineverse
{
    public partial class Login : Form
    {
        
        public static string Username { get; private set; }

        
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = guna2Button1; 
        }

        // USE ENTER TO LOGIN
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        //SHOW FIRSTNAME TO DASHBOARD
        public string GetTextBoxValue()
        {
            return txt_user.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(188, 0, 0, 0);
        }
       
        
        //METHOD - LOGIN QUERY
        public void login()
        {
            MySqlConnection conn = DBConnection.getConnection();
            SignUp signupform = new SignUp();

            if (txt_user.Text != "" && txt_pass.Text != "")
            {
                try
                {
                    string hashedPassword = "";

                    conn.Open();
                    string loginQuery = "SELECT user_id, password FROM accounts WHERE username=@username";
                    MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn);
                    loginCmd.Parameters.AddWithValue("@username", txt_user.Text);
                    MySqlDataReader reader = loginCmd.ExecuteReader();
                    while (reader.Read()) { 
                    hashedPassword = reader["password"].ToString();
                        TimeINOUT.user_id = Convert.ToInt32(reader["user_id"].ToString());
                    }

                    if (txt_user.Text.Equals("Enter Username") && txt_pass.Text.Equals("Enter Password")) {
                        string usernamePlaceholder = "Enter Username";
                        string passwordPlaceholder = "Enter Password";
                        string usernameInput = txt_user.Text.Trim();

                        // ERROR WHEN EMPTY
                        if (string.IsNullOrEmpty(usernameInput) || usernameInput == usernamePlaceholder)
                        {
                            txt_user.BorderColor = Color.Red;
                            ep_username.SetError(txt_user, "Username is Required!");
                        }
                        else
                        {
                            ep_username.SetError(txt_user, string.Empty);
                        }

                        string passwordInput = txt_pass.Text.Trim();

                        if (string.IsNullOrEmpty(passwordInput) || passwordInput == passwordPlaceholder)
                        {
                            txt_pass.BorderColor = Color.Red;
                            ep_password.SetError(txt_pass, "Password is Required!");
                        }
                        else
                        {
                            ep_password.SetError(txt_pass, string.Empty);
                        }
                    }
                    // ENCRYPTED PASSWORD CHECK
                    else if (hashedPassword.Equals(Security.Encrypt(txt_pass.Text)))
                    {
                        Username = GetTextBoxValue();

                        //CASHIER LOGIN ROLE
                        if (LoginRole.GetRole(txt_user.Text, hashedPassword) == 2)
                        {
                            TimeINOUT.TimeIn();
                        }

                        //SET GLOBAL ROLE
                        LoginRole.GlobalRole = LoginRole.GetRole(txt_user.Text, hashedPassword);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_pass.UseSystemPasswordChar = false;
                        txt_user.Text = "Enter Username";
                        txt_pass.Text = "Enter Password";

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //LOGIN BUTTON 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login();
        }

        //SIGNUP BUTTON
        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signupfrm = new SignUp();
            signupfrm.Show();
            this.Hide();
        }

        #region PLACEHOLDER EFFECTS

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Enter Username")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.White;
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Enter Username";
                txt_user.ForeColor = Color.Silver;
               
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Enter Password")
            {
                txt_pass.Text = "";
                txt_pass.ForeColor = Color.White;
                if (txt_pass.UseSystemPasswordChar == false)
                {
                    txt_pass.UseSystemPasswordChar = true;
                }
            }
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.Text = "Enter Password";
                txt_pass.ForeColor = Color.Silver;
                if (txt_pass.UseSystemPasswordChar == true)
                {
                    txt_pass.UseSystemPasswordChar = false;
                }
            }
        }
        #endregion 

        // SHOW AND HIDE PASSWORD
        private void btn_show_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar == false)
            {
                btn_hide.BringToFront();
                txt_pass.UseSystemPasswordChar = true;
            }
            btn_show.BackColor = Color.Black;
        }
        private void btn_hide_Click(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar == true)
            {
               btn_show.BringToFront();
               txt_pass.UseSystemPasswordChar = false;
            }
            btn_hide.BackColor = Color.Black;
        }

        //ERROR PROVIDER 
        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            string userInput = txt_user.Text.Trim();


            if (!string.IsNullOrEmpty(userInput) && userInput != "Enter Username")
            {
                txt_user.BorderColor = SystemColors.ControlDark;
                ep_username.SetError(txt_user, string.Empty);

            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            string passInput = txt_pass.Text.Trim();


            if (!string.IsNullOrEmpty(passInput) && passInput != "Enter Password")
            {
                txt_pass.BorderColor = SystemColors.ControlDark;
                ep_password.SetError(txt_pass, string.Empty);
            }
        }


        //SPACE DISABLED
        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        
        private void lbl_forgotPass_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
        }

        //EXIT BUTTON
        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
