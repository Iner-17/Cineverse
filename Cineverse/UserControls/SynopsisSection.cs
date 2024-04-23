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
        public SynopsisSection()
        {
            InitializeComponent();
        }

        private void SynopsisSection_Load(object sender, EventArgs e)
        {
            label5.Text = TitleFromMovieSection;
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string getTitleLists = "SELECT title FROM movies;";
                MySqlCommand cmd = new MySqlCommand(getTitleLists, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();

                while (reader.Read())
                {
                    cbo_titleLists.Items.Add(reader["title"].ToString());
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
