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

        private void lbl_date_Click(object sender, EventArgs e)
        {

        }
    }
}
