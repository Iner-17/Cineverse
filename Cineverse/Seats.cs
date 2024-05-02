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
    public partial class Seats : Form
    {
        private string username;
        public string TitleFromMovieSection { get; set; }
        Color selectedColor = Color.FromArgb(225, 48, 48);
        Color availableColor = Color.DimGray;
        Color bookedColor = Color.FromArgb(31, 178, 198);
        Color glowColor = Color.FromArgb(75, 75, 75);
        private string currentTitle;
        private string currentDate;
        private string currentTime;
        private string seatList;

        private void passDataToPaymentForm()
        {
            currentTitle = cbo_titleLists.Text;
            currentDate = cbo_dateLists.Text;
            currentTime = cbo_timeLists.Text;
            seatList = seatLists.Text;

            if(currentTitle != "" && currentDate != "" && seatList != "" && currentTime != "")
            {
                PaymentForm paymentForm = new PaymentForm();
                paymentForm.GetDataFromSeatForm(currentTitle, currentDate, currentTime, seatList);
                paymentForm.Show();


                this.Hide();
            } else
            {
                MessageBox.Show("All fields are required.");
                
            }
        }

        public Seats(string username)
        {
            InitializeComponent();
            this.username = username;
            SelectingSeats();
        }

        public Seats ()
        {
            InitializeComponent();
            SelectingSeats();
        }

        private void Seats_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            //Set movie lists
            try
            {
                conn.Open();

                string getMovieListsQuery = "SELECT title FROM movies;";
                MySqlCommand getListcmd = new MySqlCommand(getMovieListsQuery, conn);
                MySqlDataReader getListdata = getListcmd.ExecuteReader();

                cbo_titleLists.Items.Clear();

                while(getListdata.Read())
                {
                    string movieTitle = getListdata["title"].ToString();
                    cbo_titleLists.Items.Add(movieTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.");
            }
            finally 
            { 
                conn.Close();
                string titleFromMovieSection = TitleFromMovieSection;
                cbo_titleLists.Text = titleFromMovieSection;
            }
            

        }

        private void cbo_titleLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            currentTitle = cbo_titleLists.Text;

            cbo_dateLists.Items.Clear();
            cbo_timeLists.Items.Clear();

            try
            {
                conn.Open();

                string setPriceQuery = "SELECT price, duration FROM movies WHERE title=@CurrentTitle;";
                MySqlCommand setPricecmd = new MySqlCommand(setPriceQuery, conn);
                setPricecmd.Parameters.AddWithValue("CurrentTitle", currentTitle);
                MySqlDataReader getPriceData = setPricecmd.ExecuteReader();
                
                int hourCounter = 0;
                int minCounter = 0;
                if (getPriceData.Read())
                {
                    lbl_moviePrice.Text = "₱" + getPriceData["price"].ToString() + ".00";
                    int dur = Convert.ToInt32(getPriceData["duration"].ToString());
                    if (dur > 120)
                    {
                        hourCounter += 2;
                        minCounter = dur - 60;
                        lbl_movieDuration.Text = hourCounter + "hr " + minCounter + "mins";
                    } else if (dur > 60)
                    {
                        hourCounter += 1;
                        minCounter = dur - 60;
                        lbl_movieDuration.Text = hourCounter + "hr " + minCounter + "mins";
                    }
                   
                    
                }
                getPriceData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.");
            }
            finally { conn.Close(); }

            //set dates based on title
            try
            {
                conn.Open();

                string getDateListsQuery = "SELECT DISTINCT date FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE title=@currentTitle;";
                MySqlCommand getListcmd = new MySqlCommand(getDateListsQuery, conn);
                getListcmd.Parameters.AddWithValue("currentTitle", currentTitle);
                MySqlDataReader getListdata = getListcmd.ExecuteReader();

                cbo_dateLists.Items.Clear();

                while (getListdata.Read())
                {
                    string movieDate = getListdata["date"].ToString();
                    cbo_dateLists.Items.Add(movieDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + currentTitle);
            }
            finally { conn.Close(); }
        }

        private void cbo_dateLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();
            string currentDate = cbo_dateLists.Text;

            try
            {
                conn.Open();

                string getTimeListsQuery = "SELECT DISTINCT start_time FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id WHERE date=@CurrentDate AND title=@CurrentTitle;";
                MySqlCommand getListcmd = new MySqlCommand(getTimeListsQuery, conn);
                getListcmd.Parameters.AddWithValue("CurrentTitle", currentTitle);
                getListcmd.Parameters.AddWithValue("CurrentDate", currentDate);
                MySqlDataReader getListdata = getListcmd.ExecuteReader();

                cbo_timeLists.Items.Clear();

                while (getListdata.Read())
                {
                    string movieTime = getListdata["start_time"].ToString();
                    cbo_timeLists.Items.Add(movieTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured." + currentTitle);
            }
            finally { conn.Close(); }
        }

        private void cbo_timeLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();
                currentTitle = cbo_titleLists.Text;
                currentDate = cbo_dateLists.Text;
                currentTime = cbo_timeLists.Text;
                string updateSeatColorQuery = "SELECT seat_code, availability FROM movies m INNER JOIN screening sc ON m.movie_id = sc.movie_id LEFT JOIN seats s ON sc.screening_id = s.screening_id WHERE m.title = @CurrentTitle AND sc.date = @CurrentDate AND sc.start_time = @CurrentTime;";
                MySqlCommand getAvailabilitycmd = new MySqlCommand(updateSeatColorQuery, conn);
                getAvailabilitycmd.Parameters.AddWithValue("CurrentTitle", currentTitle);
                getAvailabilitycmd.Parameters.AddWithValue("CurrentDate", currentDate);
                getAvailabilitycmd.Parameters.AddWithValue("CurrentTime", currentTime);
                MySqlDataReader reader = getAvailabilitycmd.ExecuteReader();

                Dictionary<string, int> availabilityDict = new Dictionary<string, int>();

                while (reader.Read())
                {
                    string seatCode = reader["seat_code"].ToString();
                    int availability = Convert.ToInt32(reader["availability"]);
                    availabilityDict[seatCode] = availability;
                }

                // Update seatPanel colors based on availability

                for (char row = 'A'; row <= 'J'; row++)
                {
                    for (int seatNum = 1; seatNum <= 20; seatNum++)
                    {
                        string seatPanelName = $"{row}{seatNum}";

                        Control[] foundControls = Controls.Find(seatPanelName, true);
                        if (foundControls.Length > 0 && foundControls[0] is Panel seatPanel)
                        {
                            if (availabilityDict.ContainsKey(seatPanelName))
                            {
                                seatPanel.BackColor = (availabilityDict[seatPanelName] == 0) ? bookedColor : availableColor;
                            }
                            else
                            {
                                seatPanel.BackColor = availableColor;
                            }
                        }
                    }
                }

                reader.Close();

            }
            catch ( Exception ex )
            {
                MessageBox.Show("An error occurred while fetching seat availability.");
            }
            finally { conn.Close(); }
        }

        private void SelectingSeats()
        {
           
            for (char row = 'A'; row <= 'J'; row++)
            {
                for (int seatNum = 1; seatNum <= 20; seatNum++)
                {
                    string seatPanelName = $"{row}{seatNum}";

                    Control[] foundControls = Controls.Find(seatPanelName, true);
                    if (foundControls.Length > 0 && foundControls[0] is Panel seatPanel)
                    {
                        seatPanel.Click += (sender, e) =>
                        {
                            if (cbo_timeLists.Text != "" && cbo_dateLists.Text != "")
                            {

                                if (seatPanel.BackColor == bookedColor)
                                {
                                    return;
                                }
                                seatPanel.BackColor = (seatPanel.BackColor == selectedColor) ? availableColor : selectedColor;

                                if (seatLists.Text == "")
                                {
                                    seatLists.Text += seatPanelName;

                                }
                                else if (seatLists.Text == seatPanelName)
                                {
                                    seatLists.Text = "";
                                }
                                else if (seatLists.Text != "" && seatPanel.BackColor == selectedColor)
                                {

                                    seatLists.Text += ", " + seatPanelName;

                                }
                                else if (seatPanel.BackColor == availableColor)
                                {
                                    string[] selectedSeats = seatLists.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                                    selectedSeats = selectedSeats.Where(seat => seat != seatPanelName).ToArray();

                                    seatLists.Text = string.Join(", ", selectedSeats);
                                }
                            } 
                            else
                            {
                                return;
                            }
                        };
                        seatPanel.MouseEnter += (sender, e) =>
                        {
                            if (seatPanel.BackColor != bookedColor && seatPanel.BackColor != selectedColor)
                            {
                                seatPanel.BackColor = glowColor;
                            }

                        };
                        seatPanel.MouseLeave += (sender, e) =>
                        {
                            if (seatPanel.BackColor != bookedColor && seatPanel.BackColor != selectedColor)
                            {
                                seatPanel.BackColor = availableColor;
                            }
                        };
                        lbl_clearAll.MouseClick += (sender, e) =>
                        {
                            if (seatPanel.BackColor == selectedColor)
                            {
                                seatPanel.BackColor = availableColor;
                            }
                            seatLists.Text = "";
                        };
                    }
                }
            }
            

            
            
        }
        
        private void panel5_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            

            Dashboard dashboard1 = (Dashboard)Application.OpenForms["Dashboard"];
            dashboard1.btn_movies_Click(this, EventArgs.Empty);
            dashboard1.Show();
            this.Close();
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

        private void btn_payment_MouseEnter(object sender, EventArgs e)
        {
            btn_payment.BackColor = Color.FromArgb(31, 178, 198);
            btn_payment.ForeColor = Color.Black;
        }

        private void btn_payment_MouseLeave(object sender, EventArgs e)
        {
            btn_payment.BackColor = Color.FromArgb(20, 32, 32);
            btn_payment.ForeColor = Color.White;
        }

        private void lbl_clearAll_MouseEnter(object sender, EventArgs e)
        {
            lbl_clearAll.ForeColor = Color.Red;
        }

        private void lbl_clearAll_MouseLeave(object sender, EventArgs e)
        {
            lbl_clearAll.ForeColor= Color.White;
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            passDataToPaymentForm();

        }

    }
}
