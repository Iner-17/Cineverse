using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public string TitleFromMovieSection { get; set; }
        public static ComboBox GlobalComboBox { get; set; }
        public static Label GlobalLabel { get; set; }
        public SynopsisSection()
        {
            InitializeComponent();
            
        }

        private void SynopsisSection_Load(object sender, EventArgs e)
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

            GlobalLabel = lbl_Title1;
            GlobalComboBox = cbo_titleLists;
        }
      
       
        private void cbo_titleLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string query = "select title, price, genre, duration, movie_rating, description from movies where title=@Title;";

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
    }
    
}
