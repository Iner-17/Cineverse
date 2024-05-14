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
    public partial class ReceiptForm : Form
    {
        private string movieTitle = "";
        private int price = 0;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        

        private void btn_backToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_dashboard_Click(this, EventArgs.Empty);
            dashboard1.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void btn_print_MouseEnter(object sender, EventArgs e)
        {
            btn_print.BackColor = Color.FromArgb(31, 178, 198);
            btn_print.ForeColor = Color.Black;
        }

        private void btn_print_MouseLeave(object sender, EventArgs e)
        {
            btn_print.BackColor = Color.FromArgb(20, 32, 32);
            btn_print.ForeColor = Color.White;
        }

        public void passDataToReceiptForm(string title, string genre, string cinema_number, string time, string date, string seatLists)
        {
            movieTitle = title;

            lbl_titlePayment.Text = title;
            lbl_genre.Text = genre;
            lbl_cinemaNo.Text = cinema_number;
            lbl_time.Text = time;
            lbl_dateTime.Text = date;
            lbl_seats.Text = seatLists;
            
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                string getPriceQuery = "SELECT genre, price, photo, cinema_number FROM movies WHERE title=@Title;";
                MySqlCommand cmd = new MySqlCommand(getPriceQuery, conn);
                cmd.Parameters.AddWithValue("Title", lbl_titlePayment.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbl_tcktPrice.Text = "₱ " + reader["price"].ToString();
                    price = Convert.ToInt32(reader["price"]);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }


            string[] listArray = lbl_seats.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            int countSeat = listArray.Length;

            lbl_tcktQuantity.Text = countSeat.ToString();

            lbl_total1.Text = "₱ " + (countSeat * price).ToString();
            lbl_total2.Text = lbl_total1.Text;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();

            this.Hide();
        }
    }
}
