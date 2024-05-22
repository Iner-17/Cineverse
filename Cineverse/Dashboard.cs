using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private bool dashboardisActive = true;
        private bool moviesisActive = false;
        private bool scheduleisActive = false;
        private bool bookingisActive = false;
        private bool userisActive = false;
        
        public Dashboard()
        {
            InitializeComponent();
            InitializeNavigationControl();
        }

        //LIST OF USERCONTROLS
        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new DashboardSection(),
                new MoviesSection1(),
                new ScheduleSection(),
                new BookingSection(),
                new SynopsisSection(),
                new UserSection()
            };

            navigationcontrols = new NavigationControls(userControls, panel4);
            
            navigationcontrols.Display(0);
        }
        //DISPLAY USERCONTROLS
        public void navigateToMovies()
        {
            navigationcontrols.Display(1);
        }

        public void navigateToSynopsis()
        {
            navigationcontrols.Display(4);
        }

        public void navigateToDashboard()
        {
            navigationcontrols.Display(0);
        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            MoviesSection1 moviesSection1 = new MoviesSection1();
            moviesSection1.UpdateMovieList();
        }

        //LOGOUT BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            Login loginfrm = new Login();
            loginfrm.Show();
            this.Close();
        }

        
        #region HOVER EFFECTS

        private void btn_dashboard_MouseEnter(object sender, EventArgs e)
        {
            if (dashboardisActive == false)
            {
                btn_dashboard.BackColor = Color.FromArgb(31, 178, 198);
                btn_dashboard.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_dashboard_MouseLeave(object sender, EventArgs e)
        {
            if (dashboardisActive == false)
            {
                btn_dashboard.BackColor = Color.FromArgb(20, 32, 32);
                btn_dashboard.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }
        private void btn_movies_MouseEnter(object sender, EventArgs e)
        {
            if (moviesisActive == false)
            {
                btn_movies.BackColor = Color.FromArgb(31, 178, 198);
                btn_movies.ForeColor = Color.Black;
            } else
            {
                return;
            }
            
        }

        private void btn_movies_MouseLeave(object sender, EventArgs e)
        {
            if (moviesisActive == false)
            {
                btn_movies.BackColor = Color.FromArgb(20, 32, 32);
                btn_movies.ForeColor = Color.White;
            }
            else
            {
                return;
            }

        }

        private void btn_schedule_MouseEnter(object sender, EventArgs e)
        {
            if (scheduleisActive == false)
            {
                btn_schedule.BackColor = Color.FromArgb(31, 178, 198);
                btn_schedule.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_schedule_MouseLeave(object sender, EventArgs e)
        {
            if (scheduleisActive == false)
            {
                btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
                btn_schedule.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

        private void btn_bookings_MouseEnter(object sender, EventArgs e)
        {
            if (bookingisActive == false)
            {
                btn_bookings.BackColor = Color.FromArgb(31, 178, 198);
                btn_bookings.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_bookings_MouseLeave(object sender, EventArgs e)
        {
            if (bookingisActive == false)
            {
                btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
                btn_bookings.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

        private void btn_user_MouseEnter(object sender, EventArgs e)
        {
            if (userisActive == false)
            {
                btn_user.BackColor = Color.FromArgb(31, 178, 198);
                btn_user.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_user_MouseLeave(object sender, EventArgs e)
        {
            if (userisActive == false)
            {
                btn_user.BackColor = Color.FromArgb(20, 32, 32);
                btn_user.ForeColor = Color.White;
            }
            else
            {
                return;
            }
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

        #region ON CLICK EFFECTS ON BUTTON
        public void btn_dashboard_Click(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(31, 178, 198);
            btn_dashboard.ForeColor = Color.Black;

            btn_movies.BackColor = Color.FromArgb(20, 32, 32);
            btn_movies.ForeColor = Color.White;

            btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
            btn_bookings.ForeColor = Color.White;

            btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
            btn_schedule.ForeColor = Color.White;

            btn_user.BackColor = Color.FromArgb(20, 32, 32);
            btn_user.ForeColor = Color.White;

            dashboardisActive = true;
            moviesisActive = false;
            bookingisActive = false;
            scheduleisActive = false;
            userisActive = false;

            navigationcontrols.Display(0);
            
        }
        public void btn_movies_Click(object sender, EventArgs e)
        {
            btn_movies.BackColor = Color.FromArgb(31, 178, 198);
            btn_movies.ForeColor = Color.Black;

            btn_dashboard.BackColor = Color.FromArgb(20, 32, 32);
            btn_dashboard.ForeColor = Color.White;

            btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
            btn_bookings.ForeColor = Color.White;

            btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
            btn_schedule.ForeColor = Color.White;

            btn_user.BackColor = Color.FromArgb(20, 32, 32);
            btn_user.ForeColor = Color.White;

            dashboardisActive = false;
            moviesisActive = true;
            bookingisActive = false;
            scheduleisActive = false;
            userisActive = false;

            navigationcontrols.Display(1);
        }

        public void btn_schedule_Click(object sender, EventArgs e)
        {
            btn_schedule.BackColor = Color.FromArgb(31, 178, 198);
            btn_schedule.ForeColor = Color.Black;

            btn_movies.BackColor = Color.FromArgb(20, 32, 32);
            btn_movies.ForeColor = Color.White;

            btn_dashboard.BackColor = Color.FromArgb(20, 32, 32);
            btn_dashboard.ForeColor = Color.White;

            btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
            btn_bookings.ForeColor = Color.White;

            btn_user.BackColor = Color.FromArgb(20, 32, 32);
            btn_user.ForeColor = Color.White;

            dashboardisActive = false;
            moviesisActive = false;
            bookingisActive = false;
            scheduleisActive = true;
            userisActive = false;

            navigationcontrols.Display(2);
        }

        public void btn_bookings_Click(object sender, EventArgs e)
        {
            btn_bookings.BackColor = Color.FromArgb(31, 178, 198);
            btn_bookings.ForeColor = Color.Black;

            btn_movies.BackColor = Color.FromArgb(20, 32, 32);
            btn_movies.ForeColor = Color.White;

            btn_dashboard.BackColor = Color.FromArgb(20, 32, 32);
            btn_dashboard.ForeColor = Color.White;

            btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
            btn_schedule.ForeColor = Color.White;

            btn_user.BackColor = Color.FromArgb(20, 32, 32);
            btn_user.ForeColor = Color.White;

            dashboardisActive = false;
            moviesisActive = false;
            bookingisActive = true;
            scheduleisActive = false;
            userisActive = false;

            navigationcontrols.Display(3);
        }

        public void btn_user_Click(object sender, EventArgs e)
        {
            btn_bookings.BackColor = Color.FromArgb(20, 32, 32);
            btn_bookings.ForeColor = Color.White;

            btn_movies.BackColor = Color.FromArgb(20, 32, 32);
            btn_movies.ForeColor = Color.White;

            btn_dashboard.BackColor = Color.FromArgb(20, 32, 32);
            btn_dashboard.ForeColor = Color.White;

            btn_schedule.BackColor = Color.FromArgb(20, 32, 32);
            btn_schedule.ForeColor = Color.White;

            btn_user.BackColor = Color.FromArgb(31, 178, 198);
            btn_user.ForeColor = Color.Black;

            dashboardisActive = false;
            moviesisActive = false;
            bookingisActive = false;
            scheduleisActive = false;
            userisActive = true;

            navigationcontrols.Display(5);
        }
        #endregion

        private void panel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
