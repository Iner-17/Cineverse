using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cineverse.UserControls;
using Google.Protobuf;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    public partial class PaymentForm : Form
    {
        bool voucherActivated = false;
        private double price = 0;
        private int countSeat = 0;
        private string movieTitle = "";
        private double discountFromVoucher = 0;

        public PaymentForm()
        {
            InitializeComponent();
        }
        
        public void GetDataFromSeatForm(string title, string date_, string time, string seatLists)
        {
            DateTime date = DateTime.ParseExact(date_, "MMMM  dd,  yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.Now;
            string day = date.ToString("dddd");

            lbl_titlePayment.Text = title;
            lbl_time.Text = time;
            lbl_dateTime.Text = date.ToString("MMMM  dd,  yyyy") + " • " + day;
            lbl_seats.Text = seatLists;
            lbl_currentDateAndTime.Text = currentDate.ToString("dd/MM/yyyy • hh:mm tt");

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
                    lbl_tcktPrice.Text = "₱ " + Convert.ToDouble(reader["price"]).ToString("F2");
                    price = Convert.ToDouble(reader["price"]);
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

            lbl_discount.Text = "0";
            double discount = 0;
            string[] listArray = lbl_seats.Text.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            countSeat = listArray.Length;
            double vatValue = (countSeat * price) * .12;
            lbl_tcktQuantity.Text = countSeat.ToString();
            lbl_vat.Text = vatValue.ToString("F2");
            lbl_total1.Text = "₱ " + ((countSeat * price) - discount).ToString("F2");
            lbl_total2.Text = lbl_total1.Text;
        }


        //SENIOR DISCOUNT [CHECK BOX]
        private void ckb_seniorDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_seniorDiscount.Checked && voucherActivated == false)
            {
                lbl_discount.Text = "50%";
                double total = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                double discountedTotal = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                discountedTotal = discountedTotal * .50;
                lbl_total1.Text = "₱ " + (total - discountedTotal).ToString("F2");
                lbl_total2.Text = lbl_total1.Text;
                txt_cash.Text = "";
                lbl_change.Text = "CHANGE: ₱  ";
            }
            else if (voucherActivated == true)
            {
                lbl_discount.Text = "50%";

                double total = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                double discountedTotal = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                discountedTotal = discountedTotal * .10;
                lbl_total1.Text = "₱ " + ((total + discountFromVoucher) / 2).ToString("F2");
                lbl_total2.Text = lbl_total1.Text;
                txt_cash.Text = "";
                lbl_change.Text = "CHANGE: ₱";

                voucherActivated = false;
            }
            else
            {
                lbl_discount.Text = "0";
                double total = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                
                lbl_total1.Text = "₱ " + (total * 2).ToString("F2");
                lbl_total2.Text = lbl_total1.Text;
                txt_cash.Text = "";
                lbl_change.Text = "CHANGE: ₱";
            }
        }


        private void btn_voucher_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
                string deleteVoucher = "DELETE FROM vouchers WHERE voucher_code = @VoucherInput";
                MySqlCommand cmd = new MySqlCommand(deleteVoucher, conn);
                cmd.Parameters.AddWithValue("VoucherInput", txt_voucherCode.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    lbl_discount.Text = "10%";

                    double total = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                    double discountedTotal = Convert.ToDouble(lbl_total1.Text.Replace("₱ ", ""));
                    discountedTotal = discountedTotal * .10;
                    lbl_total1.Text = "₱ " + (total - discountedTotal).ToString("F2");
                    lbl_total2.Text = lbl_total1.Text;
                    txt_cash.Text = "";
                    lbl_change.Text = "CHANGE: ₱";

                    discountFromVoucher = discountedTotal;
                    voucherActivated = true;

                    Voucher voucher = new Voucher();
                    voucher.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Voucher Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            
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
                updateAvailabilityCmd.Parameters.AddWithValue("@Date", date);
                updateAvailabilityCmd.Parameters.AddWithValue("@Time", lbl_time.Text);

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

        int lastInsertedId = 0;

        private void btn_transactionComplete_Click(object sender, EventArgs e)
        {

            if (lbl_change.Text.Equals("CHANGE: ₱") || lbl_change.Text.Equals("CHANGE: ₱  "))
            {
                MessageBox.Show("Insufficient Cash.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                UpdateAvailabilityToBooked(lbl_seats.Text);

                int movie_id = 0;
                ReceiptForm receiptForm1 = new ReceiptForm();
                receiptForm1.passDataToReceiptForm(lbl_titlePayment.Text, lbl_genre.Text, lbl_cinemaNo.Text, lbl_time.Text, lbl_dateTime.Text, lbl_seats.Text, lbl_vat.Text, lbl_discount.Text, lbl_total2.Text);
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
                int bookingId = 0;
                //Insert into bookings
                try
                {
                    DateTime date = DateTime.Now;
                    DateTime time = DateTime.Now;

                    conn.Open();
                    string insertBookingData = "INSERT INTO bookings (ticket_quantity, ticket_total, currentDate, time_booked, movie_id, seats_booked) VALUES (@Ticket_quant, @Ticket_Total, @CurrentDate, @TimeBooked, @Movie_ID, @SeatsBooked);";
                    cmd = new MySqlCommand(insertBookingData, conn);
                    cmd.Parameters.AddWithValue("@Ticket_quant", lbl_tcktQuantity.Text);        
                    cmd.Parameters.AddWithValue("@Ticket_Total", Convert.ToDouble(lbl_total1.Text.Replace("₱", "")));
                    cmd.Parameters.AddWithValue("@CurrentDate", date.ToString("dd/MM/yyyy • dddd", new CultureInfo("en-PH")));
                    cmd.Parameters.AddWithValue("@TimeBooked", time.ToString("hh:mm tt"));
                    cmd.Parameters.AddWithValue("@Movie_ID", movie_id);
                    cmd.Parameters.AddWithValue("@SeatsBooked", lbl_seats.Text);

                    cmd.ExecuteNonQuery();

                    bookingId = (int)cmd.LastInsertedId;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.Close();
                }
                //Insert into receipt
                try
                {
                
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
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                //insert into cineverse revenue
                try
                {

                    conn.Open();
                    string insertBookingData = "INSERT INTO cineverse_revenue (booking_id, total_amount, vatValue) VALUES (@BookingID, @Cineverse_revenue, @VatValue);";
                    cmd = new MySqlCommand(insertBookingData, conn);
                    cmd.Parameters.AddWithValue("@BookingID", bookingId);
                    cmd.Parameters.AddWithValue("@Cineverse_revenue", Convert.ToDouble(lbl_total1.Text.Replace("₱", "")) - Convert.ToDouble(lbl_vat.Text));
                    cmd.Parameters.AddWithValue("@vatValue", Convert.ToDouble(lbl_vat.Text));
                   
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }


                BookingSection booking = new BookingSection();
                booking.BookingSection_Load(this, EventArgs.Empty);

                DashboardSection dashboardSection = new DashboardSection();
                dashboardSection.UpdateBookings();
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
            btn_submit.BackColor = Color.FromArgb(31, 178, 198);
            btn_submit.ForeColor = Color.Black;
        }

        private void btn_voucher_MouseLeave(object sender, EventArgs e)
        {
            btn_submit.BackColor = Color.FromArgb(20, 32, 32);
            btn_submit.ForeColor = Color.White;
        }

        private void pb_posterSelected_Click(object sender, EventArgs e)
        {

        }

      

        private void txt_cash_TextChanged(object sender, EventArgs e)
        {
            double cashPayement = 0;
            double change = 0;
            if (txt_cash.Text.Equals(""))
            {
                return;
            } 
            else
            {
               cashPayement = Convert.ToDouble(txt_cash.Text);
            }

            double total2 = Convert.ToDouble(lbl_total2.Text.Replace("₱", ""));

            if (cashPayement > total2)
            {
                lbl_change.Text = "CHANGE: ₱" + (cashPayement - total2);
                change = (cashPayement - total2);
            }
            else if (cashPayement == (countSeat * price))
            {
                lbl_change.Text = "CHANGE: ₱ ";
                change = (cashPayement - total2);
            } else if (cashPayement == ((countSeat * price) / 2))
            {
                lbl_change.Text = "CHANGE: ₱ ";
            } else
            {
                lbl_change.Text = "CHANGE: ₱";
            }
            ReceiptForm.Cash = cashPayement.ToString();
            ReceiptForm.Change = change.ToString();
        }

        private void txt_cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }







        private void label11_Click(object sender, EventArgs e)
        {

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
        private void btn_enterVoucherCode_MouseEnter_1(object sender, EventArgs e)
        {
            btn_enterVoucherCode.BackColor = Color.FromArgb(31, 178, 198);
            btn_enterVoucherCode.ForeColor = Color.Black;
        }

        private void btn_enterVoucherCode_MouseLeave_1(object sender, EventArgs e)
        {
            btn_enterVoucherCode.BackColor = Color.FromArgb(20, 32, 32);
            btn_enterVoucherCode.ForeColor = Color.White;
        }


        private void btn_enterVoucherCode_Click(object sender, EventArgs e)
        {
            if (pnl_voucher.Visible == false)
            {
                pnl_voucher.Visible = true;
                pnl_progress.Location = new Point(209, 152);

            }
            else
            {
                pnl_voucher.Visible = false;
                pnl_progress.Location = new Point(206, 222);

            }
        }
    }
}
