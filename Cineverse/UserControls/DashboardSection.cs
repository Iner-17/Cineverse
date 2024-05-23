using Cineverse.Properties;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cineverse
{
    public partial class DashboardSection : UserControl
    {
        private string username;
        public string Title { get; set; } //PASS TITLE TO SEATS FORM 
        public DashboardSection()
        {
            InitializeComponent();
        }

        private void DashboardSection_Load(object sender, EventArgs e)
        {
            //REMOVE STAT BUTTON FOR CASHIER ROLE
            if (LoginRole.GlobalRole == 2)
            {
                btn_statistics.Visible = false;
            }

            string username = Login.Username;   
            //DISPLAY FIRSTNAME 
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
                    string firstname = reader.GetString(0);
                    string capitalized = $"{char.ToUpper(firstname[0])}{firstname.Substring(1)}";
                    lbl_hellouser.Text = "Hello, " + capitalized + "!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        //CURRENT DATE AND TIME
            UpdateTime();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_tick;
            timer.Start();

            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMMM d, yyyy");

            lbl_date.Text = formattedDate;
            
            //OVERVIEW METHODS
            UpdateNumberOfMovies();
            UpdateBookings();
            displayMovieDashboard();
        }

        private void Timer_tick(Object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            lbl_time.Text = string.Format("{0:hh  :  mm  :  ss   tt}", DateTime.Now).ToUpper();
        }


        // THREE MOVIES DISPLAY
        public void displayMovieDashboard()
        {
            MySqlConnection conn = DBConnection.getConnection();

            for (int i = 1; i <= 3; i++)
            {
                PictureBox pb_poster = Controls.Find("pb_dbMovieDisplay" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;

                try
                {
                    conn.Open();

                    string getRandomMoviesquery = "SELECT title, duration, genre, price, photo FROM movies LIMIT 1 OFFSET " + (i-1) + ";";
                    MySqlCommand cmd = new MySqlCommand(getRandomMoviesquery, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string title = reader.GetString("title").ToUpper();
                        string duration = reader.GetInt32("duration").ToString();
                        string genre = reader.GetString("genre");
                        string price = reader.GetDouble("price").ToString("F2");
                        byte[] imageData = (byte[])reader["photo"];

                        if (imageData != null && imageData.Length > 0)
                        {
                            MemoryStream ms = new MemoryStream(imageData);
                            pb_poster.Image = Image.FromStream(ms);
                            lbl_title.Text = title;
                        }
                        else
                        {
                            pb_poster.Image = null;
                        }
                        
                        Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                        Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;
                        Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "₱" + price;
                    } 
                    else // EMPTY - PLACEHOLDER DISPLAY
                    {
                        lbl_title.Text = "Title";
                        pb_poster.Image = Properties.Resources.PosterPlaceholder1;
                        Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = "Duration";
                        Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = "Genre";
                        Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "Price";
                    }
                }

                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message);
                }
                finally { conn.Close(); }
            }

            
        }

        //TODAY'S BOOKINGS & REVENUE
        public void UpdateBookings()
        {

            DateTime dateTime = DateTime.Now;
            MySqlConnection conn = DBConnection.getConnection();
           
            //BOOKINGS
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_quantity) FROM bookings WHERE currentDate = @CurrentDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@CurrentDate", dateTime.ToString("dd/MM/yyyy • dddd", new CultureInfo("en-PH")));
                object result = cmd.ExecuteScalar();
                if (result.ToString().Equals(""))
                {
                    lbl_todaysBooking.Text = "0";
                }
                else
                {
                    lbl_todaysBooking.Text = result.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally { conn.Close(); }


            //REVENUE
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_total) FROM bookings WHERE currentDate = @CurrentDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@CurrentDate", dateTime.ToString("dd/MM/yyyy • dddd"));
                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_revenue.Text = "₱0";
                }
                else
                {
                double totalRev = Convert.ToDouble(result.ToString());
                lbl_revenue.Text = "₱" + totalRev.ToString("F2");

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally { conn.Close(); }
        }

        //NUM OF SCHEDULED MOVIES
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

        //GET TICKETS BUTTON TO SEATS FORM
        private void btn_getTickets1_Click(object sender, EventArgs e)
        {
            if (lbl_title1.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title1.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btn_getTickets2_Click(object sender, EventArgs e)
        {
            if (lbl_title1.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title2.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btn_getTickets3_Click(object sender, EventArgs e)
        {
            if (lbl_title1.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title3.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }
        //HOVER EFFECTS
        #region HOVER EFFECTS
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

        private void btn_statistics_MouseEnter(object sender, EventArgs e)
        {
            btn_statistics.BackColor = Color.FromArgb(31, 178, 198);
            btn_statistics.ForeColor = Color.Black;
        }

        private void btn_statistics_MouseLeave(object sender, EventArgs e)
        {
            btn_statistics.BackColor = Color.FromArgb(20, 32, 32);
            btn_statistics.ForeColor = Color.White;
        }
        #endregion

        
        private void lbl_viewAll_Click(object sender, EventArgs e)
        {

            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_movies_Click(this, EventArgs.Empty);
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
            ((Form)this.TopLevelControl).Close();
        }
    }
}
