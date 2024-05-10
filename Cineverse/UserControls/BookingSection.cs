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

namespace Cineverse.UserControls
{
    public partial class BookingSection : UserControl
    {
        public BookingSection()
        {
            InitializeComponent();
        }

        private void BookingSection_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = "SELECT title, time_booked, seats_booked, ticket_quantity, ticket_total FROM movies INNER JOIN bookings ON movies.movie_id = bookings.movie_id;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);   

                dgv_booking.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
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
                    getBookingidcmd.Parameters.AddWithValue("TimeBooked", selectedRow.Cells["time_booked"].Value.ToString());
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
                    string query = "SELECT movie_title, genre, cinema_number, time, date, seats_booked";
                    

                    while (reader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Ads");
                }
                finally { conn.Close(); }


            }

            
        }
    }
}
