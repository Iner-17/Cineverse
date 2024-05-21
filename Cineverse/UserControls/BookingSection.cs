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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Cineverse.UserControls
{
    public partial class BookingSection : UserControl
    {
        public BookingSection()
        {
            InitializeComponent();
        }

        public void BookingSection_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = @"
                        SELECT 
                            booking_id AS `Transaction ID`,
                            title AS `Title`, 
                            time_booked AS `Time Booked`, 
                            seats_booked AS `Seats Booked`, 
                            ticket_quantity AS `Quantity`, 
                            ticket_total AS `Total` 
                        FROM 
                            movies 
                            INNER JOIN bookings ON movies.movie_id = bookings.movie_id;";

                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);
                dt.Columns[5].DataType = typeof(double);
                dgv_booking.DataSource = dt;

                dgv_booking.Columns["Total"].DefaultCellStyle.Format = "0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgv_booking_SelectionChanged(object sender, EventArgs e)
        {
            int bookingId = 0;
            if (dgv_booking.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_booking.SelectedRows[0];

                MySqlConnection conn = DBConnection.getConnection();
                try
                {
                    conn.Open();
                    string getBookingId = "SELECT book.booking_id FROM bookings as book INNER JOIN receipt as rec ON book.booking_id = rec.booking_id WHERE time_booked = @TimeBooked AND movie_title = @Title;";
                    MySqlCommand getBookingidcmd = new MySqlCommand(getBookingId, conn);
                    getBookingidcmd.Parameters.AddWithValue("TimeBooked", selectedRow.Cells["Time Booked"].Value.ToString());
                    getBookingidcmd.Parameters.AddWithValue("Title", selectedRow.Cells["title"].Value.ToString());

                    MySqlDataReader reader = getBookingidcmd.ExecuteReader();

                    while(reader.Read())
                    {
                        bookingId = reader.GetInt32("booking_id");
                    }
                }
                catch ( Exception ex )
                {
                    MessageBox.Show(ex.Message + "Ads");
                }
                finally { conn.Close(); }

                try
                {
                    conn.Open();
                    string query = "SELECT  rec.movie_title, rec.genre, rec.cinema_number, rec.time, rec.date, book.seats_booked, book.currentDate, book.time_booked, book.ticket_quantity, book.ticket_total FROM bookings as book INNER JOIN receipt as rec ON book.booking_id = rec.booking_id WHERE rec.booking_id = @BookingId;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("BookingId", bookingId);

                    MySqlDataReader reader2 = cmd.ExecuteReader();



                    while (reader2.Read())
                    {
                        double quant = Convert.ToDouble(reader2["ticket_quantity"]);
                        double total = Convert.ToDouble(reader2["ticket_total"]);
                        double priceTotal = Convert.ToDouble(reader2["ticket_total"]);
                        double price = total / quant;
                        double cash = Convert.ToDouble(ReceiptForm.Cash);
                        double change = Convert.ToDouble(ReceiptForm.Change);

                        lbl_titlePayment.Text = reader2["movie_title"].ToString();
                        lbl_genre.Text = reader2["genre"].ToString();
                        lbl_cinemaNo.Text = reader2["cinema_number"].ToString();
                        lbl_time.Text = reader2["time"].ToString();
                        lbl_dateTime.Text = reader2["date"].ToString();
                        lbl_currentDateAndTime.Text = reader2["currentDate"].ToString().Substring(0, 13) + reader2["time_booked"].ToString();
                        lbl_seats.Text = reader2["seats_booked"].ToString();
                        lbl_quant.Text = reader2["ticket_quantity"].ToString(); 
                        lbl_ticketPrice.Text = "₱" + price.ToString("F2");
                        lbl_priceTotal.Text = "₱" + priceTotal.ToString("F2");

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
}
