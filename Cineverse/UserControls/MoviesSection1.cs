using MySql.Data.MySqlClient;
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



        private void UpdateMovieList()
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

                        string query = "SELECT title, genre, duration, photo FROM movies LIMIT 1 OFFSET " + (i-1) + ";";
                        MySqlCommand cmd = new MySqlCommand(query, conn);   

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            string title = reader.GetString("title");
                            string duration = reader.GetInt32("duration").ToString();
                            string genre = reader.GetString("genre");
                            byte[] imageData = (byte[])reader["photo"];

                            if (imageData != null && imageData.Length > 0) {
                                MemoryStream ms = new MemoryStream(imageData);
                                pb_poster.Image = Image.FromStream(ms);
                                lbl_title.Text = title;
                            } else
                            {
                                pb_poster.Image = null;
                            }
                            

                            Controls.Find("lbl_duration" + i, true).FirstOrDefault().Text = duration + " mins";
                            Controls.Find("lbl_genre" + i, true).FirstOrDefault().Text = genre;

                            
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "TITE");
                    }
                    finally { conn.Close(); }
                }
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
    }
}
