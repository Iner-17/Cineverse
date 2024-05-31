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
    public partial class EditDetails : Form
    {
        public static string title { get; set; }
        public int cinemaNum = 0;

        public EditDetails()
        {
            InitializeComponent();
        }

        private void btn_saveMovie_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();


                try
                {
                    conn.Open();

                    string updateDetails = "UPDATE movies SET title = @NewTitle, movie_rating = @Movie_rating, duration = @Duration, genre = @Genre, price = @Price, cinema_number = @Cinema_Number, description = @Description WHERE title = @Title";
                    MySqlCommand cmd = new MySqlCommand(updateDetails, conn);
                    cmd.Parameters.AddWithValue("NewTitle", txt_addTitle.Text);
                    cmd.Parameters.AddWithValue("Movie_rating", cbo_rating.Text);
                    cmd.Parameters.AddWithValue("Duration", txt_addDuration.Text);
                    cmd.Parameters.AddWithValue("Genre", cbo_addGenre.Text);
                    cmd.Parameters.AddWithValue("Price", txt_addPrice.Text);
                    cmd.Parameters.AddWithValue("Description", txt_description.Text);
                    cmd.Parameters.AddWithValue("Cinema_Number", cbo_cinemaNum.Text);
                    cmd.Parameters.AddWithValue("Title", title);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Edit saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    dashboard.btn_movies_Click(this, EventArgs.Empty);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); } 
            
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            dashboard.btn_movies_Click(this, EventArgs.Empty);

            this.Close();
        }

        private void EditDetails_Load(object sender, EventArgs e)
        {
            getCinemaNumber();
            listGenre();
            listCinemaNumber();
            listMovieRating();
            txt_addTitle.Text = SynopsisSection.GlobalLabelTitle.Text;
            txt_addPrice.Text = SynopsisSection.GlobalLabelPrice.Text;
            txt_addDuration.Text = SynopsisSection.GlobalLabelDuration.Text;
            txt_description.Text = SynopsisSection.GlobalLabelDescription.Text;
            cbo_addGenre.Text = SynopsisSection.GlobalLabelGenre.Text;
            cbo_rating.Text = SynopsisSection.GlobalLabelRating.Text;
            cbo_cinemaNum.Text = cinemaNum.ToString();

            
        }

        private void listGenre()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT cm_genreList FROM cm_genre";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbo_addGenre.Items.Add(reader["cm_genreList"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void listCinemaNumber()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT cm_cinemaNumber FROM cm_cinemanumber";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbo_cinemaNum.Items.Add(reader["cm_cinemaNumber"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void listMovieRating()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string query = "SELECT cm_movieRating FROM cm_movierating";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbo_rating.Items.Add(reader["cm_movieRating"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void getCinemaNumber()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try 
            {
                conn.Open();
                string getCinemaNum = "SELECT cinema_number FROM movies WHERE title = @Title";
                MySqlCommand cmd = new MySqlCommand(getCinemaNum, conn);
                cmd.Parameters.AddWithValue("Title", title);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    cinemaNum = Convert.ToInt32(reader["cinema_number"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void cbo_cinemaNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            //CINEMA NUMBER FULL
            try
            {
                conn.Open();
                string countCinemaNumber = "SELECT Count(cinema_number) as count from movies where cinema_number = @CinemaInput;";
                MySqlCommand countCinemaNumbercmd = new MySqlCommand(countCinemaNumber, conn);
                countCinemaNumbercmd.Parameters.AddWithValue("CinemaInput", Convert.ToInt32(cbo_cinemaNum.Text));

                MySqlDataReader reader = countCinemaNumbercmd.ExecuteReader();


                if (reader.Read())
                {
                    if (Convert.ToInt32(reader["count"].ToString()) == 3)
                    {
                        MessageBox.Show("Cinema Number " + cbo_cinemaNum.Text + " is full!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbo_cinemaNum.SelectedIndex = -1;
                        btn_saveMovie.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
