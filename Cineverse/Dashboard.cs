using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cineverse.UserControls;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    public partial class Dashboard : Form
    {
        
        public NavigationControls navigationcontrols;
        public Dashboard()
        {
            InitializeComponent();

            InitializeNavigationControl();
        }

       

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { 
                new DashboardSection(),
                new MoviesSection1(),
                new ScheduleSection(),
                new BookingSection()
                
            };

            navigationcontrols = new NavigationControls(userControls, panel4);
            
            navigationcontrols.Display(0);
        }
       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //time & date
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.Show();
            this.Close();
        }


        #region Hover effects
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
            btn_logout.BackColor = Color.DarkRed;
            btn_logout.ForeColor = Color.White;
        }

        private void btn_logout_MouseLeave(object sender, EventArgs e)
        {
            btn_logout.BackColor = Color.FromArgb(20, 32, 32);
            btn_logout.ForeColor = Color.White;
        }

        #endregion

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_movies_Click(object sender, EventArgs e)
        {
            navigationcontrols.Display(1);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            navigationcontrols.Display(0);
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            navigationcontrols.Display(2);
        }

        private void btn_bookings_Click(object sender, EventArgs e)
        {
            navigationcontrols.Display(3);
        }
    }
    
}
