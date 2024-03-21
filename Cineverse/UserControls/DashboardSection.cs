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

            UpdateNumberOfMovies();
        }

        private void Timer_tick(Object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lbl_time.Text = DateTime.Now.ToString("HH  :  mm  :  ss   tt").ToUpper();
        }

        public void UpdateNumberOfMovies()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM movies;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int movieCount = Convert.ToInt32(cmd.ExecuteScalar()); 
                lbl_numSchedMovies.Text = movieCount.ToString();
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
        private void btn_getTickets3_MouseEnter_1(object sender, EventArgs e)
        {
            btn_getTickets3.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets3.ForeColor = Color.Black;
        }

        private void btn_getTickets3_MouseLeave_1(object sender, EventArgs e)
        {
            btn_getTickets3.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets3.ForeColor = Color.White;
        }

        private void btn_getTickets1_MouseEnter_1(object sender, EventArgs e)
        {
            btn_getTickets1.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets1.ForeColor = Color.Black;
        }

        private void btn_getTickets1_MouseLeave_1(object sender, EventArgs e)
        {
            btn_getTickets1.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets1.ForeColor = Color.White;
        }

        private void btn_getTickets2_MouseEnter_1(object sender, EventArgs e)
        {
            btn_getTickets2.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets2.ForeColor = Color.Black;
        }

        private void btn_getTickets2_MouseLeave_1(object sender, EventArgs e)
        {
            btn_getTickets2.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets2.ForeColor = Color.White;
        }

        private void lbl_viewAll_MouseEnter(object sender, EventArgs e)
        {
            lbl_viewAll.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void lbl_viewAll_MouseLeave(object sender, EventArgs e)
        {
            lbl_viewAll.ForeColor = Color.White;
        }
    }
}
