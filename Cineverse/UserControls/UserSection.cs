﻿using MySql.Data.MySqlClient;
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

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;

            getUserInfo();
        }

        private void getUserInfo()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT concat(firstname, ' ' , lastname) as name, email, password FROM accounts where username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("Username", Login.Username);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string pass = reader["password"].ToString();
                    string counter = "";

                    for (int i = 0; i < pass.Length; i++)
                    {
                        counter += '*';
                    }

                    lbl_name.Text = reader["name"].ToString();
                    lbl_email.Text = reader["email"].ToString();
                    lbl_pass.Text = reader["password"].ToString().Replace(pass, counter);
                }

                DateTime currentDate = DateTime.Now;
                string formattedTime = currentDate.ToString("hh:mm") + " AM";

                lbl_timein.Text = formattedTime.ToString();

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
            Login login = new Login();
            login.Show();

            this.Hide();
        }
    }
}
