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
    public partial class DashboardSection : UserControl
    {
        private string username;
        public DashboardSection(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void DashboardSection_Load(object sender, EventArgs e)
        {
            //get firstname from database based on user's username
            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();

                string getNameQuery = "SELECT firstname FROM accounts WHERE username=@Username;";
                MySqlCommand getNamecmd = new MySqlCommand(getNameQuery, conn);
                getNamecmd.Parameters.AddWithValue("@Username", username);
                MySqlDataReader reader = getNamecmd.ExecuteReader();

                if (reader.Read())
                {
                    lbl_hellouser.Text = "Hello, " + reader.GetString(0) + "!";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


            //show current time & date
            UpdateTime();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;
        }

        private void Timer_tick(Object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lbl_time.Text = DateTime.Now.ToString("HH  :  mm  :  ss   tt").ToUpper();
        }

    }
}
