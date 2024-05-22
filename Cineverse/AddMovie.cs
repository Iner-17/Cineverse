using Cineverse.UserControls;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        
        private string fileName = "";

        private void btn_saveMovie_Click(object sender, EventArgs e)
        {
            saveMovie(); 

        }

        public static int movieId = 0;


        //SAVE MOVIE QUERY
        public void saveMovie()
        {
            MySqlConnection conn = DBConnection.getConnection();

            if(txt_addTitle.Text != "" && txt_addPrice.Text != "" && cbo_addGenre.Text != "" && txt_addDuration.Text != "" && pictureBox1.Image != null && txt_description.Text != "" && cbo_rating.Text != "" && cbo_cinemaNum.Text != "" )
            {
                int TitleInt = 0;
                //MOVIE TITLE EXISTING VALIDATION
                try
                {
                    conn.Open();
                    string titleExists = "SELECT count(title) FROM movies WHERE title = @Title;";
                    MySqlCommand checkTitlecmd = new MySqlCommand(titleExists, conn);
                    checkTitlecmd.Parameters.AddWithValue("Title", txt_addTitle.Text);

                    TitleInt = Convert.ToInt32(checkTitlecmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }


                if (TitleInt > 0)
                {
                    MessageBox.Show("Movie already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else 
                { 

                //INSERT MOVIE DETAILS QUERY
                try
                {
                    conn.Open();
                    string saveMovieQuery = "INSERT INTO movies (title, price, genre, duration, photo, description, movie_rating, cinema_number) VALUES (@Title, @Price, @Genre, @Duration, @Photo, @Description, @Rating, @CinemaNum);";
                    MySqlCommand saveMoviecmd = new MySqlCommand(saveMovieQuery, conn);
                    saveMoviecmd.Parameters.AddWithValue("@Title", txt_addTitle.Text);
                    saveMoviecmd.Parameters.AddWithValue("@Price", txt_addPrice.Text);
                    saveMoviecmd.Parameters.AddWithValue("@Genre", cbo_addGenre.Text);
                    saveMoviecmd.Parameters.AddWithValue("@Duration", txt_addDuration.Text);
                    saveMoviecmd.Parameters.AddWithValue("@Description", txt_description.Text);
                    saveMoviecmd.Parameters.AddWithValue("@Rating", cbo_rating.Text);
                    saveMoviecmd.Parameters.AddWithValue("@CinemaNum", cbo_cinemaNum.Text);
                    
                        // SAVE IMAGE TO DATABSE
                        byte[] ImageData;
                        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                        saveMoviecmd.Parameters.AddWithValue("@Photo", ImageData);
                        saveMoviecmd.ExecuteNonQuery();

                        movieId = (int)saveMoviecmd.LastInsertedId;

                        AddScreening.GlobalLabelCinemaNumber = cbo_cinemaNum.Text;
                        AddScreening.GlobalDuration = txt_addDuration.Text;

                        MessageBox.Show("Successfully Added Movie.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AddScreening addScreening = new AddScreening();
                        addScreening.Show();
                        this.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                    }
            }

            else
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        // UPLOAD IMAGE
        private void btn_uploadImage_Click(object sender, EventArgs e) 
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files | *.jpg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    fileName = openFileDialog.FileName;
                    SaveImage(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        
        private void SaveImage(string filename)
        {
        }

        //CLOSE BUTTON
        private void panel5_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();

            Dashboard dashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();

            if (dashboard != null)
            {
                
                dashboard.Close();
            }

            dashboard = new Dashboard();
            dashboard.btn_movies_Click(this, EventArgs.Empty);
            
            dashboard.Show();
            this.Close();

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
                        cbo_cinemaNum.SelectedIndex = - 1;
                        btn_saveMovie.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { conn.Close(); }   
        }

        //PRICE AND DURATION VALIDATION
        private void txt_addPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_addDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
