using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

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
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                guna2Button1.PerformClick();
            }
        }

        public string GetTextBoxValue()
        {
            return txt_user.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(188, 0, 0, 0);

        }
        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void login()
        {
            MySqlConnection conn = DBConnection.getConnection();
            if(txt_user.Text != "" && txt_pass.Text != "")
            {
                try
                {
                    conn.Open();
                    string loginQuery = "SELECT COUNT(*) FROM accounts WHERE username=@username AND password=@password;";
                    MySqlCommand loginCmd = new MySqlCommand(loginQuery, conn);
                    loginCmd.Parameters.AddWithValue("@username", txt_user.Text);
                    loginCmd.Parameters.AddWithValue("@password", txt_pass.Text);
                    object count = loginCmd.ExecuteScalar();
                    

                    if(Convert.ToInt32(count) != 1)
                    {
                        MessageBox.Show("Incorrect username or password");
                        txt_pass.UseSystemPasswordChar = false;
                        txt_user.Text = "Enter Username or Email";
                        txt_pass.Text = "Enter Password";
                    } 
                    else
                    {
                        Username = GetTextBoxValue();

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();

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
            else
            {
                MessageBox.Show("Please fill up both fields");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signupfrm = new SignUp();
            signupfrm.Show();
            this.Hide();
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Enter Username or Email")
            {
                txt_user.Text = "";
                txt_user.ForeColor = Color.White;
                
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                txt_user.Text = "Enter Username or Email";
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

    }
}
