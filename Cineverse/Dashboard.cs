using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    public partial class Dashboard : Form
    {
        private Login loginform;
        public Dashboard(Login loginform)
        {
            InitializeComponent();
            this.loginform = loginform;
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateTime();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;

            MySqlConnection conn = DBConnection.getConnection();
            string txt_user = loginform.GetTextBoxValue();


            
            try
            {
                conn.Open();
                string query = "SELECT firstname FROM accounts WHERE username=@Ussername;";
                MySqlCommand hellocmd = new MySqlCommand(query, conn);
                hellocmd.Parameters.AddWithValue("@Ussername", txt_user);
                MySqlDataReader reader = hellocmd.ExecuteReader();
               

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
        }

        private void Timer_tick(Object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lbl_time.Text = DateTime.Now.ToString("HH  :  mm  :  ss   tt").ToUpper();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.Show();
            this.Close();
        }
      
        private void btn_movies_MouseEnter(object sender, EventArgs e)
        {
            btn_movies.BackColor = Color.FromArgb(31, 178, 198);
            btn_movies.ForeColor = Color.Black;
        }

        private void btn_movies_MouseLeave(object sender, EventArgs e)
        {
            btn_movies.BackColor = Color.FromArgb(20, 32, 32);
            btn_movies.ForeColor = Color.White;
        }

        private void btn_schedule_MouseEnter(object sender, EventArgs e)
        {
            btn_schedule.BackColor = Color.FromArgb(31, 178, 198);
            btn_schedule.ForeColor = Color.Black;
        }

        private void btn_schedule_MouseLeave(object sender, EventArgs e)
        {
            btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
            btn_schedule.ForeColor = Color.White;
        }

        private void btn_bookings_MouseEnter(object sender, EventArgs e)
        {
            btn_bookings.BackColor = Color.FromArgb(31, 178, 198);
            btn_bookings.ForeColor = Color.Black;
        }

        private void btn_bookings_MouseLeave(object sender, EventArgs e)
        {
            btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
            btn_bookings.ForeColor = Color.White;
        }

        private void btn_user_MouseEnter(object sender, EventArgs e)
        {
            btn_user.BackColor = Color.FromArgb(31, 178, 198);
            btn_user.ForeColor = Color.Black;
        }

        private void btn_user_MouseLeave(object sender, EventArgs e)
        {
            btn_user.BackColor = Color.FromArgb(20, 32, 32);
            btn_user.ForeColor = Color.White;
        }

        private void btn_logout_MouseEnter(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(31, 178, 198);
            btn_logout.ForeColor = Color.Black;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(20, 32, 32);
            btn_logout.ForeColor = Color.White;
        }

        private void btn_getTickets1_MouseEnter(object sender, EventArgs e)
        {
            btn_getTickets1.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets1.ForeColor = Color.Black;
        }

        private void btn_getTickets1_MouseLeave(object sender, EventArgs e)
        {
            btn_getTickets1.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets1.ForeColor = Color.White;
        }

        private void btn_getTickets2_MouseEnter(object sender, EventArgs e)
        {
            btn_getTickets2.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets2.ForeColor = Color.Black;
        }

        private void btn_getTickets2_MouseLeave(object sender, EventArgs e)
        {
            btn_getTickets2.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets2.ForeColor = Color.White;
        }

        private void btn_getTickets3_MouseEnter(object sender, EventArgs e)
        {
            btn_getTickets3.BackColor = Color.FromArgb(31, 178, 198);
            btn_getTickets3.ForeColor = Color.Black;
        }

        private void btn_getTickets3_MouseLeave(object sender, EventArgs e)
        {
            btn_getTickets3.BackColor = Color.FromArgb(20, 32, 32);
            btn_getTickets3.ForeColor = Color.White;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
