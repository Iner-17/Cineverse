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

            if(txt_addTitle.Text != "" && txt_addPrice.Text != "" && txt_addGenre.Text != "" && txt_addDuration.Text != "" && pictureBox1.Image != null)
            {
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

                    MySqlCommand insertScreeningcmd = new MySqlCommand();

                    foreach (string date in cmb_datesAdded.Items)
                    {
                        foreach (string time in cmb_timeAdded.Items)
                        {
                            string insertScreeningQuery = "INSERT INTO screening (movie_id, date, start_time) VALUES (@Movie_Id, @Date, @Time);";
                            insertScreeningcmd = new MySqlCommand(insertScreeningQuery, conn);
                            insertScreeningcmd.Parameters.AddWithValue("@Movie_Id", movieId);
                            insertScreeningcmd.Parameters.AddWithValue("@Date", date);
                            insertScreeningcmd.Parameters.AddWithValue("@Time", time);
                            insertScreeningcmd.ExecuteNonQuery();
                      

                    List<string> excludedSeatCodes = new List<string> { "A2", "A3", "A4", "A17", "A18", "A19", "B2", "B3", "B19", "C8", "C13", "D8", "D13", "E8", "E13", "F8", "F13", "G8", "G13", "H8", "H13", "I8", "I13", "J8", "J13" };
                    int screeningId = (int)insertScreeningcmd.LastInsertedId;
                    for (char row = 'A'; row <= 'J';  row++)
                    {
                        for (int seatNum = 2; seatNum <= 19; seatNum++)
                        {
                            string seatCodes = $"{row}{seatNum}";

                            if(!excludedSeatCodes.Contains(seatCodes))
                            {
                                string generateSeatQuery = "INSERT INTO seats (screening_id, seat_code, availability) VALUES (@Screening_Id, @Seat_code, 1);";
                                MySqlCommand generateSeatcmd = new MySqlCommand(generateSeatQuery, conn);
                                generateSeatcmd.Parameters.AddWithValue("@Screening_Id", screeningId);
                                generateSeatcmd.Parameters.AddWithValue("@Seat_code", seatCodes);
                                generateSeatcmd.ExecuteNonQuery();
                            }
                        }
                    }
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
            else
            {
                MessageBox.Show("All fields are required.");
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

    }
}
