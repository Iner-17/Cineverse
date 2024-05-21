using Cineverse.UserControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cineverse
{
    public partial class AddScreening : Form
    {
        private bool cinema1isActive = false;
        private bool cinema2isActive = false;
        private bool cinema3isActive = false;
        private bool cinema4isActive = false;
        public static string GlobalLabelCinemaNumber { get; set; }
        public static string GlobalDuration { get; set; }

        int cinemaNum = 0;  
        public AddScreening()
        {
            InitializeComponent();
        }

        private void AddScreening_Load(object sender, EventArgs e)
        {
            lbl_cinemaNumber.Text = GlobalLabelCinemaNumber;
            cinemaNum = Convert.ToInt32(lbl_cinemaNumber.Text);
        }

        private void currentDateScreeningsWithCinemaNumber(int cinemaNumber)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = "SELECT title as Title, start_time as Time, duration as xDuration FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE screening.date = @SelectedDate AND movies.cinema_number = @CinemaNumber;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                getListcmd.Parameters.AddWithValue("SelectedDate", dtp_date.Text);
                getListcmd.Parameters.AddWithValue("CinemaNumber", cinemaNumber);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);    
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                dt.Columns.Add("Duration", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int duration = Convert.ToInt32(row["xDuration"]);
                    int hours = duration / 60;
                    int minutes = duration % 60;
                    row["Duration"] = $"{hours}hr {minutes}mins";
                }

                dt.Columns.Remove("xDuration");

                dgv_booking.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            currentDateScreeningsWithCinemaNumber(cinemaNum);
        }



        private void btn_addDate_Click_1(object sender, EventArgs e)
        {
            if (dtp_date.Value < DateTime.Today)
            {
                MessageBox.Show("Cannot set date before " + DateTime.Today.ToString("MMMM dd yyyy"));
            }
            else
            {
                if (cmb_datesAdded.Items.Count < 1)
                {
                    cmb_datesAdded.Items.Add(dtp_date.Text);
                }
                else
                {
                    MessageBox.Show("Can only set 1 Date per Screening", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_addTime_Click(object sender, EventArgs e)
        {

            string inputTime = dtp_time.Text;
            DateTime startTime = DateTime.ParseExact(inputTime, "HH:mm", null);

            int lastIndexAddedTime = cmb_timeAdded.Items.Count - 1;
            int lastIndexDGVTime = dgv_booking.Rows.Count - 2;

            bool isConflict = false;

            if (dgv_booking.Rows.Count > 1)
            {
                object lastDGVTime = dgv_booking.Rows[lastIndexDGVTime].Cells["Time"].Value;
                string lastDGVDuration = dgv_booking.Rows[lastIndexDGVTime].Cells["Duration"].Value.ToString().Replace("hr", "").Replace("mins", "").Trim();

                string[] timeParts = lastDGVDuration.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int hours = 0;
                int minutes = 0;

                if (timeParts.Length > 0)
                {
                    hours = int.Parse(timeParts[0]);
                }
                if (timeParts.Length > 1)
                {
                    minutes = int.Parse(timeParts[1]);
                }

                int lastDurationfromDGV = (hours * 60) + minutes;

                // Parse time from DataGridView with AM/PM
                DateTime endTimeFromDGV = DateTime.Parse(lastDGVTime.ToString());

                endTimeFromDGV = endTimeFromDGV.AddMinutes(Convert.ToInt32(lastDurationfromDGV));

                if (startTime <= endTimeFromDGV)
                {
                    isConflict = true;
                }
            }

            if (lastIndexAddedTime >= 0 && !isConflict)
            {
                object mostCurrentItem = cmb_timeAdded.Items[lastIndexAddedTime];
                // Parse time from ComboBox with AM/PM
                DateTime endTime = DateTime.Parse(mostCurrentItem.ToString());
                endTime = endTime.AddMinutes(Convert.ToInt32(GlobalDuration));

                if (startTime <= endTime)
                {
                    isConflict = true;
                }
            }

            if (!isConflict)
            {
                string formattedInputTime = startTime.ToString("h:mm tt");
                cmb_timeAdded.Items.Add(formattedInputTime);
            }
            else
            {
                MessageBox.Show("There'll be conflicts with your time");
            }
        }   



        private void btn_addScreening_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

           
            try
            {
                if (cmb_datesAdded.Items.Count > 0 && cmb_timeAdded.Items.Count > 0)
                {
                    conn.Open();
                    MySqlCommand insertScreeningcmd = new MySqlCommand();

                    foreach (string date in cmb_datesAdded.Items)
                    {
                        foreach (string time in cmb_timeAdded.Items)
                        {

                            string insertScreeningQuery = "INSERT INTO screening (movie_id, date, start_time) VALUES (@Movie_Id, @Date, @Time);";
                            insertScreeningcmd = new MySqlCommand(insertScreeningQuery, conn);
                            insertScreeningcmd.Parameters.AddWithValue("@Movie_Id", AddMovie.movieId);
                            insertScreeningcmd.Parameters.AddWithValue("@Date", date);
                            insertScreeningcmd.Parameters.AddWithValue("@Time", time);
                            insertScreeningcmd.ExecuteNonQuery();


                            List<string> excludedSeatCodes = new List<string> { "A2", "A3", "A4", "A17", "A18", "A19", "B2", "B3", "B19", "C8", "C13", "D8", "D13", "E8", "E13", "F8", "F13", "G8", "G13", "H8", "H13", "I8", "I13", "J8", "J13" };
                            int screeningId = (int)insertScreeningcmd.LastInsertedId;

                            for (char row = 'A'; row <= 'J'; row++)
                            {
                                for (int seatNum = 2; seatNum <= 19; seatNum++)
                                {
                                    string seatCodes = $"{row}{seatNum}";

                                    if (!excludedSeatCodes.Contains(seatCodes))
                                    {
                                        string generateSeatQuery = "INSERT INTO seats (screening_id, seat_code, availability) VALUES (@Screening_Id, @Seat_code, 1);";
                                        MySqlCommand generateSeatcmd = new MySqlCommand(generateSeatQuery, conn);
                                        generateSeatcmd.Parameters.AddWithValue("@Screening_Id", screeningId);
                                        generateSeatcmd.Parameters.AddWithValue("@Seat_code", seatCodes);
                                        generateSeatcmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                    MessageBox.Show("Screening successfully added.");

                    cmb_datesAdded.Items.Clear();
                    cmb_timeAdded.Items.Clear();
                    currentDateScreeningsWithCinemaNumber(cinemaNum);
                } 
                else
                {
                    MessageBox.Show("No date or time added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            ScheduleSection sc = new ScheduleSection();
            sc.getSchedule();
        }

        private void btn_addDate_MouseEnter(object sender, EventArgs e)
        {
            btn_addDate.BackColor = Color.FromArgb(31, 178, 198);
            btn_addDate.ForeColor = Color.Black;
        }

        private void btn_addDate_MouseLeave(object sender, EventArgs e)
        {
            btn_addDate.BackColor = Color.FromArgb(20, 32, 32);
            btn_addDate.ForeColor = Color.White;
        }

        private void btn_addTime_MouseEnter(object sender, EventArgs e)
        {
            btn_addTime.BackColor = Color.FromArgb(31, 178, 198);
            btn_addTime.ForeColor = Color.Black;
        }

        private void btn_addTime_MouseLeave(object sender, EventArgs e)
        {
            btn_addTime.BackColor = Color.FromArgb(20, 32, 32);
            btn_addTime.ForeColor = Color.White;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();

            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

            if (dashboard != null)
            {
                // Close the other form if it's open
                dashboard.Close();
            }

            // Open the other form
            dashboard = new Dashboard();
            dashboard.btn_movies_Click(this, EventArgs.Empty);
            dashboard.Show();
            this.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();

            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

            if (dashboard != null)
            {
                // Close the other form if it's open
                dashboard.Close();
            }

            // Open the other form
            dashboard = new Dashboard();
            dashboard.navigateToMovies();
            dashboard.Show();

            this.Close();
        }
    
    }
}
