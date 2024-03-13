using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cineverse
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(188, 0, 0, 0);

        }
        private void panel5_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            this.Close();
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
                        txt_user.Text = "";
                        txt_pass.Text = "";
                    } 
                    else
                    {
                        SignUp signupfrm = new SignUp();
                        signupfrm.Show();
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
    }
}
