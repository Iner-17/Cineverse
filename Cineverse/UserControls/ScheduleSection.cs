using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse.UserControls
{
    public partial class ScheduleSection : UserControl
    {
        private bool allButtonisActive = false;
        private bool todayButtonisActive = false;
        private bool thisWeekButtonisActive = false;

        public ScheduleSection()
        {
            InitializeComponent();
        }

        private void ScheduleSection_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();

                string query = "select distinct title from movies";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_movies.Items.Add(reader["title"].ToString().ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            getSchedule();
        }


        public void getSchedule()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = "SELECT title AS Title, date AS Date, start_time AS Time, " +
                    "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                    " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dgv_booking.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            cbo_movies.SelectedIndex = -1;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            btn_all.BackColor = Color.FromArgb(31, 178, 198);
            btn_all.ForeColor = Color.Black;

            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;

            btn_thisWeek.BackColor = Color.FromArgb(20, 32, 32);
            btn_thisWeek.ForeColor = Color.White;

            allButtonisActive = true;
            todayButtonisActive = false;
            thisWeekButtonisActive = false;

            getSchedule();
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            if (cbo_movies.Text.Equals(""))
            {
                try
                {
                    conn.Open();

                    string getListquery = "SELECT title, date, start_time, " +
                        "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                        " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE screening.date = @CurrentDate;";
                    MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                    getListcmd.Parameters.AddWithValue("CurrentDate", DateTime.Today.ToString("MMMM  dd,  yyy"));
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dgv_booking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            } else
            {
                try
                {
                    conn.Open();

                    string getListquery = "SELECT title, date, start_time, " +
                        "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                        " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE screening.date = @CurrentDate AND movies.title = @MovieTitle;";
                    MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                    getListcmd.Parameters.AddWithValue("MovieTitle", cbo_movies.Text);
                    getListcmd.Parameters.AddWithValue("CurrentDate", DateTime.Today.ToString("MMMM  dd,  yyy"));
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dgv_booking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }

            btn_all.BackColor = Color.FromArgb(20, 32, 32);
            btn_all.ForeColor = Color.White;

            btn_today.BackColor = Color.FromArgb(31, 178, 198);
            btn_today.ForeColor = Color.Black;

            btn_thisWeek.BackColor = Color.FromArgb(20, 32, 32);
            btn_thisWeek.ForeColor = Color.White;

            allButtonisActive = false;
            todayButtonisActive = true;
            thisWeekButtonisActive = false;

        }

        private void cbo_movies_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            if (!cbo_movies.Text.Equals(""))
            {
                try
                {
                    conn.Open();

                    string getListquery = "SELECT title, date, start_time, " +
                        "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                        " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE movies.title = @MovieTitle;";
                    MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                    getListcmd.Parameters.AddWithValue("MovieTitle", cbo_movies.Text);
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dgv_booking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
            
        }

        private void lbl_refresh_MouseEnter(object sender, EventArgs e)
        {
            lbl_refresh.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void lbl_refresh_MouseLeave(object sender, EventArgs e)
        {
            lbl_refresh.ForeColor = Color.White;
        }

        private void btn_today_MouseEnter(object sender, EventArgs e)
        {
            if (todayButtonisActive == false)
            { 
                btn_today.BackColor = Color.FromArgb(31, 178, 198);
                btn_today.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_today_MouseLeave(object sender, EventArgs e)
        {
            if (todayButtonisActive == false)
            {
                btn_today.BackColor = Color.FromArgb(20, 32, 32);
                btn_today.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

        private void btn_thisWeek_MouseEnter(object sender, EventArgs e)
        {
            if (thisWeekButtonisActive == false)
            {
                btn_thisWeek.BackColor = Color.FromArgb(31, 178, 198);
                btn_thisWeek.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_thisWeek_MouseLeave(object sender, EventArgs e)
        {
            if (thisWeekButtonisActive == false)
            {
                btn_thisWeek.BackColor = Color.FromArgb(20, 32, 32);
                btn_thisWeek.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

       

        private void btn_all_MouseEnter(object sender, EventArgs e)
        {
            if (allButtonisActive == false)
            {
                btn_all.BackColor = Color.FromArgb(31, 178, 198);
                btn_all.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
            
        }

        private void btn_all_MouseLeave(object sender, EventArgs e)
        {
            if (allButtonisActive == false)
            {
                btn_all.BackColor = Color.FromArgb(20, 32, 32);
                btn_all.ForeColor = Color.White;
            }
            else
            {
                return;
            }
            
        }

        private void btn_thisWeek_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            DateTime currentDate = DateTime.Today;
            DateTime startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek); // Assuming Monday is the start of the week
            DateTime endDate = startDate.AddDays(6);
            if (cbo_movies.Text.Equals(""))
            {
                try
                {
                    conn.Open();

                    string getListquery = "SELECT title, date, start_time, " +
                        "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                        " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE screening.date BETWEEN @StartDate AND @EndDate";
                    MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                    getListcmd.Parameters.AddWithValue("StartDate", startDate.ToString("MMMM  dd,  yyy"));
                    getListcmd.Parameters.AddWithValue("EndDate", endDate.ToString("MMMM  dd,  yyy"));
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dgv_booking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            } 
            else
            {
                try
                {
                    conn.Open();

                    string getListquery = "SELECT title, date, start_time, " +
                        "(SELECT COUNT(*) FROM seats WHERE screening_id = screening.screening_id AND availability = 1) AS available_seats, cinema_number" +
                        " FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE screening.date BETWEEN @StartDate AND @EndDate AND movies.title = @MovieTitle;";
                    MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                    getListcmd.Parameters.AddWithValue("MovieTitle", cbo_movies.Text);
                    getListcmd.Parameters.AddWithValue("StartDate", startDate.ToString("MMMM  dd,  yyy"));
                    getListcmd.Parameters.AddWithValue("EndDate", endDate.ToString("MMMM  dd,  yyy"));
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    dgv_booking.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }

            }

            btn_all.BackColor = Color.FromArgb(20, 32, 32);
            btn_all.ForeColor = Color.White;

            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;

            btn_thisWeek.BackColor = Color.FromArgb(31, 178, 198);
            btn_thisWeek.ForeColor = Color.Black;

            allButtonisActive = false;
            todayButtonisActive = false;
            thisWeekButtonisActive = true;
        }
    }
}
