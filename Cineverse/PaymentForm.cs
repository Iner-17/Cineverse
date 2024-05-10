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
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        private int price = 0;
        private string movieTitle = "";
        public void GetDataFromSeatForm(string title, string date_, string time, string seatLists)
        {
            DateTime date = DateTime.ParseExact(date_, "MMMM  dd,  yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string day = date.ToString("dddd");

            lbl_titlePayment.Text = title;
            lbl_time.Text = time;
            lbl_dateTime.Text = date.ToString("MMMM  dd,  yyyy") + " • " + day;
            lbl_seats.Text = seatLists;


            movieTitle = title;
        }

        

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            
            try
            {
                conn.Open();
                string getPriceQuery = "SELECT genre, price, photo, cinema_number FROM movies WHERE title=@Title;";
                MySqlCommand cmd = new MySqlCommand(getPriceQuery, conn);
                cmd.Parameters.AddWithValue("Title", lbl_titlePayment.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    lbl_tcktPrice.Text = "₱ " + reader["price"].ToString();
                    price = Convert.ToInt32(reader["price"]);
                    lbl_genre.Text = reader["genre"].ToString();

                    byte[] imgdata = (byte[])reader["photo"];

                    if (imgdata != null && imgdata.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(imgdata);
                        pb_posterSelected.Image = Image.FromStream(ms);
                        lbl_cinemaNo.Text = "Cinema " + reader["cinema_number"].ToString();
                    }
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
                string date = dateTimeParts[0].Trim(); // date is the first part
                string time = dateTimeParts[1].Trim(); // time is the second part
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

            int movie_id = 0;
            ReceiptForm receiptForm1 = new ReceiptForm();
            receiptForm1.passDataToReceiptForm(lbl_titlePayment.Text, lbl_genre.Text, lbl_cinemaNo.Text, lbl_time.Text, lbl_dateTime.Text, lbl_seats.Text);
            receiptForm1.Show();
            this.Hide();

            MySqlConnection conn = DBConnection.getConnection();
            
            try
            {
                conn.Open();
                string query = "SELECT movie_id FROM movies WHERE title = @Title";
                MySqlCommand getMovieIdcmd = new MySqlCommand(query, conn);
                getMovieIdcmd.Parameters.AddWithValue("Title", movieTitle);

                MySqlDataReader reader = getMovieIdcmd.ExecuteReader();
                if (reader.Read())
                {
                    movie_id = reader.GetInt32("movie_id");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            MySqlCommand cmd = new MySqlCommand();

            try
            {
                DateTime date = DateTime.UtcNow.Date;
                DateTime time = DateTime.Now;

                conn.Open();
                string insertBookingData = "INSERT INTO bookings (ticket_quantity, ticket_total, currentDate, time_booked, movie_id, seats_booked) VALUES (@Ticket_quant, @Ticket_Total, @CurrentDate, @TimeBooked, @Movie_ID, @SeatsBooked);";
                cmd = new MySqlCommand(insertBookingData, conn);
                cmd.Parameters.AddWithValue("@Ticket_quant", lbl_tcktQuantity.Text);
                cmd.Parameters.AddWithValue("@Ticket_Total", price * Convert.ToInt32(lbl_tcktQuantity.Text));
                cmd.Parameters.AddWithValue("@CurrentDate", date.ToString("dd/MM/yyyy • dddd"));
                cmd.Parameters.AddWithValue("@TimeBooked", time.ToString("hh:mm tt"));
                cmd.Parameters.AddWithValue("@Movie_ID", movie_id);
                cmd.Parameters.AddWithValue("@SeatsBooked", lbl_seats.Text);

                cmd.ExecuteNonQuery();

            } catch (Exception ex)
            {
                MessageBox.Show(""  + ex);
            } finally
            {
                conn.Close();
            }
            
            try
            {
                int bookingId = (int)cmd.LastInsertedId;

                conn.Open();
                string insertBookingData = "INSERT INTO receipt (booking_id, movie_title, genre, cinema_number, time, date) VALUES (@BookingID, @Title, @Genre, @CinemaNumber, @Time, @Date);";
                cmd = new MySqlCommand(insertBookingData, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingId);
                cmd.Parameters.AddWithValue("@Title", lbl_titlePayment.Text);
                cmd.Parameters.AddWithValue("@Genre", lbl_genre.Text);
                cmd.Parameters.AddWithValue("@CinemaNumber", lbl_cinemaNo.Text);
                cmd.Parameters.AddWithValue("@Time", lbl_time.Text);
                cmd.Parameters.AddWithValue("@Date", lbl_dateTime.Text);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.Close();
            }

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

        private void btn_voucher_MouseEnter(object sender, EventArgs e)
        {
            btn_voucher.BackColor = Color.FromArgb(31, 178, 198);
            btn_voucher.ForeColor = Color.Black;
        }

        private void btn_voucher_MouseLeave(object sender, EventArgs e)
        {
            btn_voucher.BackColor = Color.FromArgb(20, 32, 32);
            btn_voucher.ForeColor = Color.White;
        }
    }
}
