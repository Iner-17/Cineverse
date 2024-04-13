using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        public void GetDataFromSeatForm(string title, string date, string time, string seatLists)
        {
            lbl_titlePayment.Text = title;
            lbl_dateTime.Text = date + " • " + time;
            lbl_seats.Text = seatLists;
        }


        private void PaymentForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            int price = 0;
            try
            {
                conn.Open();
                string getPriceQuery = "SELECT price FROM movies WHERE title=@Title;";
                MySqlCommand cmd = new MySqlCommand(getPriceQuery, conn);
                cmd.Parameters.AddWithValue("Title", lbl_titlePayment.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
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


            string[] listArray = lbl_seats.Text.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            int countSeat = listArray.Length;

            lbl_tcktQuantity.Text = countSeat.ToString();

            lbl_total1.Text = "₱ " + (countSeat * price).ToString();
            lbl_total2.Text = lbl_total1.Text;
        }

        private void UpdateAvailabilityToBooked(string seatList)
        {
            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
                string[] selectedSeats = seatList.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string updateAvailabilityQuery = "UPDATE seats SET availability = 0 WHERE screening_id IN (SELECT screening_id FROM screening INNER JOIN movies ON screening.movie_id = movies.movie_id WHERE movies.title = @Title AND screening.date = @Date AND screening.start_time = @Time) AND seat_code IN (";

                // Add seat codes to the update query
                for (int i = 0; i < selectedSeats.Length; i++)
                {
                    updateAvailabilityQuery += $"@SeatCode{i}";
                    if (i < selectedSeats.Length - 1)
                        updateAvailabilityQuery += ", ";
                }

                updateAvailabilityQuery += ");";

                MySqlCommand updateAvailabilityCmd = new MySqlCommand(updateAvailabilityQuery, conn);
                updateAvailabilityCmd.Parameters.AddWithValue("@Title", lbl_titlePayment.Text);

                // Split lbl_dateTime.Text to extract date and time separately
                string[] dateTimeParts = lbl_dateTime.Text.Split(new string[] { " • " }, StringSplitOptions.RemoveEmptyEntries);
                string date = dateTimeParts[0].Trim(); // Assuming date is the first part
                string time = dateTimeParts[1].Trim(); // Assuming time is the second part
                updateAvailabilityCmd.Parameters.AddWithValue("@Date", date);
                updateAvailabilityCmd.Parameters.AddWithValue("@Time", time);

                // Add parameters for each seat code
                for (int i = 0; i < selectedSeats.Length; i++)
                {
                    updateAvailabilityCmd.Parameters.AddWithValue($"SeatCode{i}", selectedSeats[i]);
                }

                // Execute the update command
                updateAvailabilityCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { conn.Close(); }
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.FromArgb(31, 178, 198);
            btn_back.ForeColor = Color.Black;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor = Color.FromArgb(20, 32, 32);
            btn_back.ForeColor = Color.White;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();

            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();

            this.Hide();
        }

        private void btn_transactionComplete_Click(object sender, EventArgs e)
        {
            UpdateAvailabilityToBooked(lbl_seats.Text);
            confirmedPaymentSection1.Location = new Point(0,0);
        }

        private int dotCount = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dotCount = (dotCount + 1) % 4;

            string dots = new string ('.', dotCount);
            lbl_paymentInProgress.Text = "Payment in Progress" + dots;
        }

        private void StartPaymentProcess()
        {
            timer_paymentInProgress.Start();

            Task.Delay(5000).ContinueWith(_ =>
            {
                StopPaymentProcess();
            });
        }

        private void StopPaymentProcess()
        {
            timer_paymentInProgress.Stop();
        }
    }
}
