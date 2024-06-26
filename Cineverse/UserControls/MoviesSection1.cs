﻿using Cineverse.UserControls;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        public static string CinemaNumber { get; set; }


        public MoviesSection1()
        {
            InitializeComponent();
        }

        public void MoviesSection1_Load(object sender, EventArgs e)
        {
            
            UpdateMovieList();
            //HIDE ADD MOVIES BUTTON
            if (LoginRole.GlobalRole == 2)
            {
                btn_addMovies.Visible = false; 
            }
        }

        //HoverEffects on buttons
        #region HoverEffects on buttons
        private void btn_getTickets2_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
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
        private void btn_gt10_MouseEnter(object sender, EventArgs e)
        {
            btn_gt10.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt10.ForeColor = Color.Black;
        }

        private void btn_gt10_MouseLeave(object sender, EventArgs e)
        {
            btn_gt10.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt10.ForeColor = Color.White;
        }

        private void btn_gt11_MouseEnter(object sender, EventArgs e)
        {
            btn_gt11.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt11.ForeColor = Color.Black;
        }

        private void btn_gt11_MouseLeave(object sender, EventArgs e)
        {
            btn_gt11.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt11.ForeColor = Color.White;
        }

        private void btn_gt12_MouseEnter(object sender, EventArgs e)
        {
            btn_gt12.BackColor = Color.FromArgb(31, 178, 198);
            btn_gt12.ForeColor = Color.Black;
        }

        private void btn_gt12_MouseLeave(object sender, EventArgs e)
        {
            btn_gt12.BackColor = Color.FromArgb(20, 32, 32);
            btn_gt12.ForeColor = Color.White;
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


        //METHOD DISPLAY MOVIES PER CINEMA NUM
        public void UpdateMovieList()
        {
            MySqlConnection conn = DBConnection.getConnection();

            for (int i = 1; i <= 3; i++) 
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;
              
                if(lbl_title != null && lbl_title.Text == "Title")
                {

                    //CINEMA 1
                    try
                    {
                        conn.Open();
                        string query = "SELECT title, movie_rating, price, genre, duration, photo FROM movies WHERE cinema_number = 1 LIMIT 1 OFFSET " + (i-1) + ";";
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

                            pb_poster.Visible = true;
                            lbl_title.Visible = true;
                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("delete" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                } 
                else
                {
                    pb_poster.Visible = false;
                    lbl_title.Visible = false;
                    Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("delete" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = false;
                }
            }


            //CINEMA 2

            for (int i = 4; i <= 6; i++)
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;

                if (lbl_title != null && lbl_title.Text == "Title")
                {

                    try
                    {
                        conn.Open();
                        string query = "SELECT title, movie_rating, price, genre, duration, photo FROM movies WHERE cinema_number = 2 LIMIT 1 OFFSET " + (i - 4) + ";";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string title = reader.GetString("title").ToUpper();
                            string movie_rating = reader.GetString("movie_rating");
                            string duration = reader.GetInt32("duration").ToString();
                            string genre = reader.GetString("genre");
                            string price = reader.GetDouble("price").ToString(); ;
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

                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Text = movie_rating;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "₱" + price + ".00";

                            // DISPLAY MOVIES
                            pb_poster.Visible = true;
                            lbl_title.Visible = true;
                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("delete" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                    
                }
                else
                {
                    // HIDE MOVIE PLACEHOLDERS WHEN EMPTY
                    pb_poster.Visible = false;
                    lbl_title.Visible = false;
                    Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("delete" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = false;
                }
            }

            //CINEMA 3

            for (int i = 7; i <= 9; i++)
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;

                if (lbl_title != null && lbl_title.Text == "Title")
                {

                    try
                    {
                        conn.Open();
                        string query = "SELECT title, movie_rating, price, genre, duration, photo FROM movies WHERE cinema_number = 3 LIMIT 1 OFFSET " + (i - 7) + ";";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string title = reader.GetString("title").ToUpper();
                            string movie_rating = reader.GetString("movie_rating");
                            string duration = reader.GetInt32("duration").ToString();
                            string genre = reader.GetString("genre");
                            string price = reader.GetDouble("price").ToString(); ;
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

                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Text = movie_rating;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "₱" + price + ".00";


                            // DISPLAY MOVIES
                            pb_poster.Visible = true;
                            lbl_title.Visible = true;
                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("delete" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                }
                else
                {
                    // HIDE MOVIE PLACEHOLDERS WHEN EMPTY
                    pb_poster.Visible = false;
                    lbl_title.Visible = false;
                    Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("delete" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = false;
                }
            }

            //CINEMA 4

            for (int i = 10; i <= 12; i++)
            {
                PictureBox pb_poster = Controls.Find("pb_Poster" + i, true).FirstOrDefault() as PictureBox;
                Label lbl_title = Controls.Find("lbl_title" + i, true).FirstOrDefault() as Label;

                if (lbl_title != null && lbl_title.Text == "Title")
                {

                    try
                    {
                        conn.Open();
                        string query = "SELECT title, movie_rating, price, genre, duration, photo FROM movies WHERE cinema_number = 4 LIMIT 1 OFFSET " + (i - 10) + ";";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string title = reader.GetString("title").ToUpper();
                            string movie_rating = reader.GetString("movie_rating");
                            string duration = reader.GetInt32("duration").ToString();
                            string genre = reader.GetString("genre");
                            string price = reader.GetDouble("price").ToString(); ;
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

                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Text = movie_rating;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Text = "₱" + price + ".00";

                            // DISPLAY MOVIES
                            pb_poster.Visible = true;
                            lbl_title.Visible = true;
                            Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("delete" + i, true).FirstOrDefault().Visible = true;
                            Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); }
                }
                else
                {
                    // HIDE MOVIE PLACEHOLDERS WHEN EMPTY
                    pb_poster.Visible = false;
                    lbl_title.Visible = false;
                    Controls.Find("lbl_rating" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_duration" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_genre" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("lbl_price" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("btn_gt" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("delete" + i, true).FirstOrDefault().Visible = false;
                    Controls.Find("synopsis" + i, true).FirstOrDefault().Visible = false;
                }
            }
          
        }

      
        //GET TICKETS BUTTON 
        private void btn_gt1_Click(object sender, EventArgs e)
        {
            //NO MOVIE
            if (lbl_title1.Text.Equals("Title"))
            {
                return;
            }
            //HAS MOVIE
            else
            {
                Title = lbl_title1.Text;
                CinemaNumber = "1";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "1";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "1";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "2";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "2";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "2";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "3";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "3";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
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
                CinemaNumber = "3";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btn_gt10_Click(object sender, EventArgs e)
        {
            if (lbl_title10.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title10.Text;
                CinemaNumber = "4";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btn_gt11_Click(object sender, EventArgs e)
        {
            if (lbl_title11.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title11.Text;
                CinemaNumber = "4";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }

        private void btn_gt12_Click(object sender, EventArgs e)
        {
            if (lbl_title12.Text.Equals("Title"))
            {
                return;
            }
            else
            {
                Title = lbl_title12.Text;
                CinemaNumber = "4";
                Seats seatsForm = new Seats(username);
                seatsForm.TitleFromMovieSection = Title;

                seatsForm.Show();

                ((Form)this.TopLevelControl).Close();
            }
        }
        
        //SYNOPSIS BUTTONS PASSING TITLE
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

        private void synopsis10_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title10.Text);
        }

        private void synopsis11_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title11.Text);
        }

        private void synopsis12_Click(object sender, EventArgs e)
        {
            navigateSynopsis(lbl_title12.Text);
        }

        // METHOD FOR SYNOPSIS BUTTON
        private void navigateSynopsis(string movieTitle)
        {

            MySqlConnection conn = DBConnection.getConnection();
            string title = "",cinemaRating = "", duration = "",description = "", genre = "", price = "";


            if (movieTitle != "Title")
            {
                try
                {
                    conn.Open();
                    string getMovieData = "SELECT title, price, genre, duration, description, photo, movie_rating FROM movies WHERE title = @Title;";
                    MySqlCommand cmd = new MySqlCommand(getMovieData, conn);
                    cmd.Parameters.AddWithValue("Title", movieTitle);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        title = reader["title"].ToString();
                        cinemaRating = reader["movie_rating"].ToString();
                        duration = reader["duration"].ToString();
                        description = reader["description"].ToString();
                        genre = reader["genre"].ToString();
                        price = reader["price"].ToString();

                        byte[] imageData = (byte[])reader["photo"];

                        if (imageData != null && imageData.Length > 0)
                        {
                            MemoryStream ms = new MemoryStream(imageData);
                            SynopsisSection.GlobalPictureBox.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            SynopsisSection.GlobalPictureBox.Image = null;
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
                SynopsisSection.GlobalLabelTitle.Text = title;
                SynopsisSection.GlobalLabelRating.Text = cinemaRating;
                SynopsisSection.GlobalLabelDuration.Text = duration;
                SynopsisSection.GlobalLabelDescription.Text = description;
                SynopsisSection.GlobalLabelGenre.Text = genre;
                SynopsisSection.GlobalLabelPrice.Text = price;

                SynopsisSection.GlobalComboBox.Text = title;

                Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
                dashboard1.navigateToSynopsis();
            }
            else
            {
                return;
            }
            
        }

        //DELETE BUTTON BASED ON TITLE
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

        private void panel13_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title10.Text);
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title11.Text);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            deleteButton(lbl_title12.Text);
        }

        //METHOD DELETE BUTTON
        public void deleteButton(string movieTitle)
        {

            if (movieTitle != "Title") { 
                DialogResult result = MessageBox.Show(

               "Do you really want to delete the movie?",
               "Delete Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1 

            );
            // YES - DELETE SUCCESSFULLY
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

                        SynopsisSection.GlobalComboBox.Items.Remove(movieTitle);

                        reset();
                        UpdateMovieList();

                        DashboardSection dashboardSection = new DashboardSection();
                        dashboardSection.displayMovieDashboard();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { conn.Close(); 
                    }

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
                } 
        
            else
            {
                return;
            }
                
            }
        }

        //RESET AFTER DELETE
        private void reset()
        {
            for (int i = 1; i <= 12; i++)
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


    }
}
