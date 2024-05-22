using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cineverse.UserControls
{
    public partial class SynopsisSection : UserControl
    {
        //GLOBALLING TOOLBOX CONTROLS
        public static ComboBox GlobalComboBox { get; set; }
        public static Label GlobalLabelTitle { get; set; }
        public static Label GlobalLabelRating { get; set; }
        public static Label GlobalLabelDuration { get; set; }
        public static Label GlobalLabelGenre { get; set; }
        public static Label GlobalLabelPrice { get; set; }
        public static Label GlobalLabelDescription { get; set; }

        public static PictureBox GlobalPictureBox { get; set; }

        public SynopsisSection()
        {
            InitializeComponent();
            
        }

        //QUERY GETTING TITLE ADD TO COMBOBOX
        public void SynopsisSection_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string getTitleLists = "SELECT title FROM movies;";
                MySqlCommand cmd = new MySqlCommand(getTitleLists, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbo_titleLists.Items.Add(reader["title"].ToString().ToUpper());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            GlobalLabelTitle = lbl_Title1;
            GlobalLabelRating = lbl_rating;
            GlobalLabelDuration = lbl_duration1;
            GlobalLabelGenre = lbl_genre1;
            GlobalLabelPrice = lbl_price1;
            GlobalLabelDescription = lbl_description;
            GlobalComboBox = cbo_titleLists;
            GlobalPictureBox = pb_Poster1;

            //MOVIE DETAILS QUERY BASED ON TITLE ONLOAD
            try
            {
                conn.Open();

                string query = "select title, price, genre, duration, movie_rating, description, photo from movies where title=@Title;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Title", lbl_Title1.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    lbl_Title1.Text = reader["title"].ToString().ToUpper();
                    lbl_rating.Text = reader["movie_rating"].ToString();
                    lbl_duration1.Text = reader["duration"].ToString() + " " + "mins.";
                    lbl_genre1.Text = reader["genre"].ToString();
                    lbl_price1.Text = "₱" + reader["price"].ToString() + ".00";
                    lbl_description.Text = reader["description"].ToString();
                    byte[] imageData = (byte[])reader["photo"];

                    if (imageData != null && imageData.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(imageData);
                        pb_Poster1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pb_Poster1.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
      
       //GET MOVIE DETAILS BASED ON TITLE CHANGE
        private void cbo_titleLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string query = "select title, price, genre, duration, movie_rating, description, photo from movies where title=@Title;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("Title", cbo_titleLists.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                   
                    lbl_Title1.Text = reader["title"].ToString().ToUpper();
                    lbl_rating.Text = reader["movie_rating"].ToString();
                    lbl_duration1.Text = reader["duration"].ToString() + " " + "mins.";
                    lbl_genre1.Text = reader["genre"].ToString();
                    lbl_price1.Text = "₱" + reader["price"].ToString() + ".00";
                    lbl_description.Text = reader["description"].ToString();
                    byte[] imageData = (byte[])reader["photo"];

                    if (imageData != null && imageData.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(imageData);
                        pb_Poster1.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pb_Poster1.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btn_backk_MouseEnter(object sender, EventArgs e)
        {
            btn_backk.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void btn_backk_MouseLeave(object sender, EventArgs e)
        {
            btn_backk.ForeColor = Color.White;
        }

        private void btn_backk_Click(object sender, EventArgs e)
        {
            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_movies_Click(this, EventArgs.Empty);
        }
    }
    
}
