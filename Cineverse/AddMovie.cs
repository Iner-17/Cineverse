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
    public partial class AddMovie : Form
    {

        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btn_addDate_Click(object sender, EventArgs e)
        {
            cmb_datesAdded.Items.Add(dtp_date.Text);
        }

        private void btn_addTime_Click(object sender, EventArgs e)
        {
            cmb_timeAdded.Items.Add(dtp_time.Text);
        }

        private string fileName = "";

        private void btn_saveMovie_Click(object sender, EventArgs e)
        {
            saveMovie();

        }

        public void saveMovie()
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string saveMovieQuery = "INSERT INTO movies (title, price, genre, duration, photo) VALUES (@Title, @Price, @Genre, @Duration, @Photo);";
                MySqlCommand saveMoviecmd = new MySqlCommand(saveMovieQuery, conn);
                saveMoviecmd.Parameters.AddWithValue("@Title", txt_addTitle.Text);
                saveMoviecmd.Parameters.AddWithValue("@Price", txt_addPrice.Text);
                saveMoviecmd.Parameters.AddWithValue("@Genre", txt_addGenre.Text);
                saveMoviecmd.Parameters.AddWithValue("@Duration", txt_addDuration.Text);
                
                byte[] ImageData;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                saveMoviecmd.Parameters.AddWithValue("@Photo", ImageData);
                saveMoviecmd.ExecuteNonQuery();


                int movieId = (int)saveMoviecmd.LastInsertedId;

                foreach (string date in cmb_datesAdded.Items)
                {
                    foreach (string time in cmb_timeAdded.Items)
                    {
                        string insertScreeningQuery = "INSERT INTO screening (movie_id, date, start_time) VALUES (@Movie_Id, @Date, @Time);";
                        MySqlCommand insertScreeningcmd = new MySqlCommand(insertScreeningQuery, conn);
                        insertScreeningcmd.Parameters.AddWithValue("@Movie_Id", movieId);
                        insertScreeningcmd.Parameters.AddWithValue("@Date", date);
                        insertScreeningcmd.Parameters.AddWithValue("@Time", time);
                        insertScreeningcmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Successfully Added Movie.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
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
            this.Close();
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
