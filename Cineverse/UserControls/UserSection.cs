using Cineverse;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
       
        private void panel2_Click(object sender, EventArgs e)
        {
            if (lbl_name.Visible == true)
            {
                txt_fname.Visible = true;
                txt_lname.Visible = true;
                btn_save.Visible = true;

                lbl_name.Visible = false;
            } else
            {
                txt_fname.Visible = false;
                txt_lname.Visible = false;
                btn_save.Visible = false;

                lbl_name.Visible = true;
            }
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (lbl_email.Visible == true)
            {
                txt_email.Visible = true;

                btn_save.Visible = true;
                lbl_email.Visible = false;
            } else
            {
                txt_email.Visible = false;

                btn_save.Visible = false;
                lbl_email.Visible = true;
            }
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (lbl_contactNo.Visible == true)
            {
                txt_contact.Visible = true;
                btn_save.Visible = true;
                lbl_contactNo.Visible = false;
            } else
            {
                txt_contact.Visible = false;
                btn_save.Visible = false;
                lbl_contactNo.Visible = true;
            }
           
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            bool isConflict = false;
            if (txt_fname.Text != "" && txt_lname.Text != "") 
            {
                if (txt_fname.TextLength > 2 && txt_lname.TextLength > 2)
                {
                    lbl_name.Text = txt_fname.Text + " " + txt_lname.Text;
                    lbl_name.Visible=true;
                    MySqlConnection conn = DBConnection.getConnection();

                    try
                    {
                        conn.Open();
                        string query = "UPDATE accounts SET firstname = @Fname, lastname = @Lname WHERE username = @Username;";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("Fname", txt_fname.Text);
                        cmd.Parameters.AddWithValue("Lname", txt_lname.Text);
                        cmd.Parameters.AddWithValue("Username", Login.Username);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Edit saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_save.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    txt_fname.Text = "";
                    txt_fname.Visible = false;
                    txt_lname.Visible = false;
                } else
                {
                    MessageBox.Show("First namne and Last name should be atleast 2 characters each", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txt_email.Text != "")
            {


                string email = txt_email.Text;
                Regex regex = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                    + "@"
                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
                Match match = regex.Match(email);
                if (match.Success)
                {
                    lbl_email.Text = txt_email.Text;
                    lbl_email.Visible = true;
                    MySqlConnection conn = DBConnection.getConnection();

                    try
                    {
                        conn.Open();
                        string query = "UPDATE accounts SET email = @Email WHERE username = @Username;";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("Email", txt_email.Text);
                        cmd.Parameters.AddWithValue("Username", Login.Username);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Edit saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_save.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    txt_email.Text = "";
                    txt_email.Visible = false;
                } 
                else
                {
                    MessageBox.Show("Invalid Email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txt_contact.Text != "")
            {

                if (!txt_contact.Text.StartsWith("09"))
                {
                    MessageBox.Show("Contact Number should start with 09", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contact.Text = "";
                } else if (txt_contact.TextLength != 11)
                {
                    MessageBox.Show("Number should be a minimum of 11 digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contact.Text = "";
                } 
                else
                {
                    lbl_contactNo.Text = txt_contact.Text;
                    lbl_contactNo.Visible = true;
                    MySqlConnection conn = DBConnection.getConnection();

                    try
                    {
                        conn.Open();
                        string query = "UPDATE accounts SET phone_number = @Contact WHERE username = @Username;";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("Contact", txt_contact.Text);
                        cmd.Parameters.AddWithValue("Username", Login.Username);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Edit saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_save.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    txt_contact.Text = "";

                    txt_contact.Visible = false;
                }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (txt_contact.Text.Length >= 11 && e.KeyChar != '\b')
            {
                e.Handled = true;

            }
        }
    }
}
