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

        public void saveMovie()
        {
            MySqlConnection conn = DBConnection.getConnection();

            if(txt_addTitle.Text != "" && txt_addPrice.Text != "" && cbo_addGenre.Text != "" && txt_addDuration.Text != "" && pictureBox1.Image != null && txt_description.Text != "" && cbo_rating.Text != "" && cbo_cinemaNum.Text != "" )
            {
                int TitleInt = 0;
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
                    

                        byte[] ImageData;
                        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                        saveMoviecmd.Parameters.AddWithValue("@Photo", ImageData);
                        saveMoviecmd.ExecuteNonQuery();

                        movieId = (int)saveMoviecmd.LastInsertedId;

                    
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
                // Close the other form if it's open
                dashboard.Close();
            }

            // Open the other form
            dashboard = new Dashboard();
            dashboard.btn_movies_Click(this, EventArgs.Empty);
            
            dashboard.Show();
            this.Close();

        }

       
    }
}
