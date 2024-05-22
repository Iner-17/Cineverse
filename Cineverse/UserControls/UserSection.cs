using Cineverse;
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

namespace Cineverse.UserControls
{
    public partial class UserSection : UserControl
    {
        public UserSection()
        {
            InitializeComponent();
        }

        private void UserSection_Load(object sender, EventArgs e)
        {
            if (LoginRole.GlobalRole == 1)
            {
                label4.Visible= false;
                lbl_timein.Visible= false;
                btn_timeOut.Visible= false;

                lbl_myProfile.Text = "ADMIN'S PROFILE";
                getAdminInfo();
            } 


            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;
            getCashierInfo();
        }

        int userId = 0;

        private void getCashierInfo()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT concat(firstname, ' ' , lastname) as name, email, password, phone_number, time_in FROM accounts INNER JOIN employee ON accounts.user_id = employee.user_id WHERE accounts.username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", Login.Username);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string pass = reader["password"].ToString();
                    string counter = "";
                    string decryptedPass = Security.Decrypt(pass);

                    for (int i = 0; i < decryptedPass.Length; i++)
                    {
                        counter += '*';
                    }

                    lbl_name.Text = reader["name"].ToString();
                    lbl_email.Text = reader["email"].ToString();
                    lbl_pass.Text = decryptedPass.Replace(decryptedPass, counter);
                    lbl_contactNo.Text = reader["phone_number"].ToString();
                    lbl_timein.Text = reader["time_in"].ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }

        }


        private void getAdminInfo()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT concat(firstname, ' ' , lastname) as name, email, password, phone_number FROM accounts WHERE accounts.username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", Login.Username);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string pass = reader["password"].ToString();
                    string counter = "";
                    string decryptedPass = Security.Decrypt(pass);

                    for (int i = 0; i < decryptedPass.Length; i++)
                    {
                        counter += '*';
                    }

                    lbl_name.Text = reader["name"].ToString();
                    lbl_email.Text = reader["email"].ToString();
                    lbl_pass.Text = decryptedPass.Replace(decryptedPass, counter);
                    lbl_contactNo.Text = reader["phone_number"].ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private string fileName = "";
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files | *.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_profile.Image = Image.FromFile(openFileDialog.FileName);
                    fileName = openFileDialog.FileName;
                    SaveImage(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveImage(string filename)
        {
        }
        
        private void btn_timeOut_Click(object sender, EventArgs e)
        {
            TimeINOUT.TimeOut();

            Login login = new Login();
            login.Show();

            this.ParentForm.Close();
        }
    }
}
