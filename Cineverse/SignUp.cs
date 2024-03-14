using MySql.Data.MySqlClient;
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
                if (txt_password.UseSystemPasswordChar == false)
                {
                    txt_password.UseSystemPasswordChar = true;
                } 
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
                if (txt_password.UseSystemPasswordChar == true)
                {
                    txt_password.UseSystemPasswordChar = false;
                }
            }
        }

        private void txt_confirmPassword_Enter(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "Confirm Password")
            {
                txt_confirmPassword.Text = "";
                txt_confirmPassword.ForeColor = Color.White;
                if (txt_confirmPassword.UseSystemPasswordChar == false)
                {
                    txt_confirmPassword.UseSystemPasswordChar = true;
                }
            }

            
        }

        private void txt_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text == "")
            {
                txt_confirmPassword.Text = "Confirm Password";
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
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private void signUp()
        {
            MySqlConnection conn = DBConnection.getConnection();


            if (txt_firstName.Text != "First Name" && txt_lastName.Text != "Last Name" && txt_email.Text != "Email (Optional)" && txt_username.Text != "Username" && txt_password.Text != "Password" && txt_confirmPassword.Text != "Confirm Password")
            {
                if (txt_confirmPassword.Text == txt_password.Text)
                {
                    try
                    {
                        conn.Open();

                        string signupQuery = "INSERT INTO accounts (firstname, lastname, email, username, password) VALUES (@Firstname, @Lastname, @Email, @Username, @Password);";
                        MySqlCommand signupcmd = new MySqlCommand(signupQuery, conn);
                        signupcmd.Parameters.AddWithValue("@Firstname", txt_firstName.Text);
                        signupcmd.Parameters.AddWithValue("@Lastname", txt_lastName.Text);
                        signupcmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        signupcmd.Parameters.AddWithValue("@Username", txt_username.Text);
                        signupcmd.Parameters.AddWithValue("@Password", txt_password.Text);
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
                    MessageBox.Show("Unmatched Password");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all fields");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(188, 0, 0, 0);
        }
    }
}