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
        private double price = 0;
        DateTime currentDate = DateTime.Now;
        public static string Cash { get; set; }
        public static string Change { get; set; }
        public ReceiptForm()
        {
            InitializeComponent();
        }



        public void passDataToReceiptForm(string title, string genre, string cinema_number, string time, string date, string seatLists, string vatValue, string discount, string totalAmount)
        {
            double discountPercentage = Convert.ToDouble(discount.Replace("%", ""));
            double totalAmountValue = Convert.ToDouble(totalAmount.Replace("₱",""));
            double initiateValue = totalAmountValue / (1 - (discountPercentage / 100));
            double discountValue = initiateValue - totalAmountValue;

            movieTitle = title;
            lbl_currentDateAndTime.Text = currentDate.ToString("dd/MM/yyyy • hh:mm tt");
            lbl_titlePayment.Text = title;
            lbl_genre.Text = genre;
            lbl_cinemaNo.Text = cinema_number;
            lbl_time.Text = time;
            lbl_dateTime.Text = date;
            lbl_seats.Text = seatLists;
            lbl_vat.Text = Convert.ToDouble(vatValue).ToString("F2");    
            lbl_discount.Text = discountValue != 0 ? discountValue.ToString("F2") : "0";
            double total = Convert.ToDouble(totalAmount.Replace("₱", ""));
            lbl_total1.Text = "₱" + total.ToString("F2");
            label3.Text = "Discount (" + discount + "):";
            
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
                    lbl_tcktPrice.Text = "₱ " + Convert.ToDouble(reader["price"]).ToString("F2");
                    price = Convert.ToDouble(reader["price"]);
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
            double cash = Convert.ToDouble(Cash);
            double change = Convert.ToDouble(Change);
            lbl_cash.Text = "₱ " + cash.ToString("F2");
            if (change == 0)
            {
                lbl_change.Text = change.ToString();
            } else
            {
                lbl_change.Text = "₱ " + change.ToString("F2");

            }
        }

        private void btn_backToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard1 = new Dashboard();
            dashboard1.Show();
            ((Form)this.TopLevelControl).Close();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Seats seats = new Seats();
            seats.Show();

            this.Hide();
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
    }
}
