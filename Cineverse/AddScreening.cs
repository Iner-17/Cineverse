using Cineverse.UserControls;
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
    public partial class AddScreening : Form
    {
        public AddScreening()
        {
            InitializeComponent();
        }

        private void AddScreening_Load(object sender, EventArgs e)
        {

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
            string[] time = dtp_time.Text.Split(':');
            int timeInt = int.Parse(time[0] + time[1]);

            if (timeInt >= 1000 && timeInt <= 1159)
            {
                cmb_timeAdded.Items.Add(dtp_time.Text + " AM");
            }
            else if (timeInt >= 1200 && timeInt <= 1259 || timeInt >= 100 && timeInt <= 959)
            {
                cmb_timeAdded.Items.Add(dtp_time.Text + " PM");
            }
        }

        private void btn_addScreening_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
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
            dashboard.navigateToMovies();
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
