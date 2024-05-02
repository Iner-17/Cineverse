using Cineverse.UserControls;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{

    public partial class MoviesSection1 : UserControl
    {
        private string username;
        public string Title { get; set; }
        
        public MoviesSection1()
        {
            InitializeComponent();
        }

        private void MoviesSection1_Load(object sender, EventArgs e)
        {
            UpdateMovieList();
        }

        //HoverEffects on buttons
        #region HoverEffects on buttons
        private void btn_getTickets2_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
            addMovie.BringToFront();
        }

        private void btn_gt1_MouseEnter(object sender, EventArgs e)
        {
            btn_gt1.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt1.ForeColor = Color.Black;
        }

        private void btn_gt1_MouseLeave(object sender, EventArgs e)
        {
            btn_gt1.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt1.ForeColor = Color.White;
        }

        private void btn_gt2_MouseEnter(object sender, EventArgs e)
        {
            btn_gt2.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt2.ForeColor = Color.Black;
        }

        private void btn_gt2_MouseLeave(object sender, EventArgs e)
        {
            btn_gt2.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt2.ForeColor = Color.White;
        }

        private void btn_gt3_MouseEnter(object sender, EventArgs e)
        {
            btn_gt3.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt3.ForeColor = Color.Black;
        }

        private void btn_gt3_MouseLeave(object sender, EventArgs e)
        {
            btn_gt3.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt3.ForeColor = Color.White;
        }

        private void btn_gt4_MouseEnter(object sender, EventArgs e)
        {
            btn_gt4.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt4.ForeColor = Color.Black;
        }

        private void btn_gt4_MouseLeave(object sender, EventArgs e)
        {
            btn_gt4.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt4.ForeColor = Color.White;
        }

        private void btn_gt5_MouseEnter(object sender, EventArgs e)
        {
            btn_gt5.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt5.ForeColor = Color.Black;
        }

        private void btn_gt5_MouseLeave(object sender, EventArgs e)
        {
            btn_gt5.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt5.ForeColor = Color.White;
        }

        private void btn_gt6_MouseEnter(object sender, EventArgs e)
        {
            btn_gt6.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt6.ForeColor = Color.Black;
        }

        private void btn_gt6_MouseLeave(object sender, EventArgs e)
        {
            btn_gt6.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt6.ForeColor = Color.White;
        }

        private void btn_gt7_MouseEnter(object sender, EventArgs e)
        {
            btn_gt7.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt7.ForeColor = Color.Black;
        }

        private void btn_gt7_MouseLeave(object sender, EventArgs e)
        {
            btn_gt7.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt7.ForeColor = Color.White;
        }

        private void btn_gt8_MouseEnter(object sender, EventArgs e)
        {
            btn_gt8.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt8.ForeColor = Color.Black;
        }

        private void btn_gt8_MouseLeave(object sender, EventArgs e)
        {
            btn_gt8.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt8.ForeColor = Color.White;
        }

        private void btn_gt9_MouseEnter(object sender, EventArgs e)
        {
            btn_gt9.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt9.ForeColor = Color.Black;
        }

        private void btn_gt9_MouseLeave(object sender, EventArgs e)
        {
            btn_gt9.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt9.ForeColor = Color.White;
        }

        private void btn_addMovies_MouseEnter(object sender, EventArgs e)
        {
            btn_addMovies.BackColor = Color.FromArgb(31, 178, 198);
            btn_addMovies.ForeColor = Color.Black;
        }

        private void btn_addMovies_MouseLeave(object sender, EventArgs e)
        {
            btn_addMovies.BackColor = Color.FromArgb(20, 32, 32);
            btn_addMovies.ForeColor = Color.White;
        }

        #endregion

        private void btn_backk_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ParentForm is Dashboard dashboard)
            {
                // Display the Dashboard user control
                dashboard.navigationcontrols.Display(0);
            }
        }



        public void UpdateMovieList()
        {
            MySqlConnection conn = DBConnection.getConnection();

            for (int i = 1; i <= 9; i++) 
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;
              
                if(lbl_title != null && lbl_title.Text == "Title")
                {
                    
                    try
                    {
                        conn.Open();

                        string query = "SELECT title, movie_rating, price, genre, duration, photo FROM movies LIMIT 1 OFFSET " + (i-1) + ";";
                        MySqlCommand cmd = new MySqlCommand(query, conn);   

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            string title = reader.GetString("title").ToUpper();
                            string movie_rating = reader.GetString("movie_rating");
                            string duration = reader.GetInt32("duration").ToString();
                            string genre = reader.GetString("genre");
                            string price = reader.GetDouble("price").ToString(); ;
                            byte[] imageData = (byte[])reader["photo"];

                            if (imageData != null && imageData.Length > 0) {
                                MemoryStream ms = new MemoryStream(imageData);
                                pb_poster.Image = Image.FromStream(ms);
                                lbl_title.Text = title;
                            } else
                            {
                                pb_poster.Image = null;
                            }
                            
                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Text = movie_rating;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;  
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "₱" + price + ".00";
                        } 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                }
            }
        }

        private void reset()
        {
            for (int i = 1; i <= 9; i++)
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;
                Image placeholder = Cineverse.Properties.Resources.PosterPlaceholder;

                lbl_title.Text = "Title";
                Controls.Find("lbl_rating" + i, true).FirstOrDefault().Text = "Rating";
                Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = "Duration";
                Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = "Genre";
                Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "Price";
                pb_poster.Image = placeholder;
            }
        }

        //RELOAD
        private void label1_Click_1(object sender, EventArgs e)
        {
            UpdateMovieList();
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void btn_backk_MouseEnter(object sender, EventArgs e)
        {
            btn_backk.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void btn_backk_MouseLeave(object sender, EventArgs e)
        {
            btn_backk.ForeColor = Color.White;
        }

        
        private void btn_gt1_Click(object sender, EventArgs e)
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

                ((Form)this.TopLevelControl).Hide();
            }

        }

        private void btn_gt2_Click(object sender, EventArgs e)
        {

            if (lbl_title2.Text.Equals("Title"))
            {
                return;
            } else
            {
                Title = lbl_title2.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
            
        }

        private void btn_gt3_Click(object sender, EventArgs e)
        {
            if (lbl_title3.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title3.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt4_Click(object sender, EventArgs e)
        {
            if (lbl_title4.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title4.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt5_Click(object sender, EventArgs e)
        {
            if (lbl_title5.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title5.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt6_Click(object sender, EventArgs e)
        {
            if (lbl_title6.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title6.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt7_Click(object sender, EventArgs e)
        {
            if (lbl_title7.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title7.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt8_Click(object sender, EventArgs e)
        {
            if (lbl_title8.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title8.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void btn_gt9_Click(object sender, EventArgs e)
        {
            if (lbl_title9.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title9.Text;

                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Hide();
            }
        }

        private void lbl_price1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title1.Text);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title2.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title3.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title4.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title5.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title6.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title7.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title8.Text);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title9.Text);
        }

        private void navigateSynopsis(string movieTitle)
        {
            Dashboard dashboard = new Dashboard();

            if (movieTitle != "Title")
            {
                SynopsisSection.GlobalLabel.Text = movieTitle;
                SynopsisSection.GlobalComboBox.Text = movieTitle;

                Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
                dashboard1.navigateToSynopsis();
            }
            else
            {
                return;
            }
            
        }

       

        private void lbl_title7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title1.Text);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title2.Text);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title3.Text);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title4.Text);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title5.Text);
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title6.Text);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title7.Text);
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title8.Text);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title9.Text);
        }

        private void deleteButton(string movieTitle)
        {

            if (movieTitle != "Title") { 
                DialogResult result = MessageBox.Show(

               "Do you really want to delete the movie?",
               "Delete Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1 // Default button is "Yes"

            );

            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBConnection.getConnection();

                    try
                    {
                        conn.Open();
                        string deleteMovie = "delete from movies where title = @Title";
                        MySqlCommand deleteMoviecmd = new MySqlCommand(deleteMovie, conn);
                        deleteMoviecmd.Parameters.AddWithValue("Title", movieTitle);
                        deleteMoviecmd.ExecuteNonQuery();
                        MessageBox.Show("Movie deleted successfully.");
                        Image placeholder = Cineverse.Properties.Resources.PosterPlaceholder;

                        reset();
                        UpdateMovieList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                } 
        
                else
                {
                    return;
                }
               
            }
        }

        private void btn_backk_Click(object sender, EventArgs e)
        {
            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_dashboard_Click(this, EventArgs.Empty);
        }

        
    }
}
