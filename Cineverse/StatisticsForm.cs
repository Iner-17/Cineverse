using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Cineverse
{
    public partial class StatisticsForm : Form
    {

        private bool todayButtonisActive = false;
        private bool dailyButtonisActive = false;
        private bool weeklyButtonisActive = false;
        private bool monthlyButtonisActive = false;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            btn_today_Click(this, EventArgs.Empty);
            TodayStatisticsRevenue();
            populateDonutChart();
        }

        private void populateDonutChart()
        {
            TopMoviesChart.Series.Clear();
            MySqlConnection conn = DBConnection.getConnection();

            string mostSoldMovie = "SELECT movies.title, SUM(cineverse_revenue.total_amount) AS Total " +
                "FROM movies INNER JOIN bookings ON movies.movie_id = bookings.movie_id " +
                "INNER JOIN cineverse_revenue ON bookings.booking_id = cineverse_revenue.booking_id GROUP BY movies.title";
            MySqlCommand mostSoldMoviecmd = new MySqlCommand(mostSoldMovie, conn);

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter(mostSoldMoviecmd);
            adapter.Fill(dt);

            Series series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Doughnut
            };

            series.Font = new Font("Montserrat", 10, FontStyle.Bold); 
            series.LabelForeColor = Color.Black; 


            foreach (DataRow row in dt.Rows)
            {
                string title = row["title"].ToString();
                double totalSale = Convert.ToDouble(row["Total"]);

                DataPoint dataPoint = series.Points.Add(totalSale);
                dataPoint.Label = $"₱ {totalSale.ToString("F2")}"; 
                dataPoint.AxisLabel = title;
                dataPoint.LegendText = title;
            }

            TopMoviesChart.Series.Add(series);
        }





        private List<DataPoint> revenueDataPoints = new List<DataPoint>();

        private void ResetChartArea()
        {
            var chartArea = RevenueChart.ChartAreas[0];
            chartArea.AxisX.Minimum = double.NaN;
            chartArea.AxisX.Maximum = double.NaN;
            chartArea.AxisX.Interval = double.NaN;
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisX.LabelStyle.Format = string.Empty;
            chartArea.AxisX.LabelStyle.Interval = double.NaN;
            chartArea.AxisX.LabelStyle.Enabled = true;
        }

        //HOURLY REVENUE
        private void displayTodaysRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            ResetChartArea();
            if (tbl == null) return;

            var sortedRevenue = tbl.AsEnumerable().OrderBy(row => DateTime.Parse(row.Field<string>("time_booked")));

            Series splineSeries = new Series("Total Revenue")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.FromArgb(31, 178, 198),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
            };

            Series areaSeries = new Series("Gradient Area")
            {
                ChartType = SeriesChartType.SplineArea,
                BorderWidth = 0
            };
            areaSeries.BackGradientStyle = GradientStyle.TopBottom;

            foreach (var row in sortedRevenue)
            {
                DateTime date = DateTime.Parse(row.Field<string>("time_booked"));
                double totalRevenue = row.Field<double>("Revenue");

                if (date.TimeOfDay >= TimeSpan.FromHours(10) && date.TimeOfDay <= TimeSpan.FromHours(22))
                {
                    DataPoint dataPoint = new DataPoint();
                    dataPoint.AxisLabel = date.ToString("hh tt");
                    dataPoint.SetValueXY(date, totalRevenue);

                    splineSeries.Points.AddXY(date, totalRevenue);
                    areaSeries.Points.AddXY(date, totalRevenue);
                }
            }

            areaSeries.Color = System.Drawing.Color.FromArgb(31, 178, 198);
            RevenueChart.Series.Add(splineSeries);
            RevenueChart.Series.Add(areaSeries);

            var chartArea = RevenueChart.ChartAreas[0];
            chartArea.AxisX.Minimum = DateTime.Today.AddHours(9.5).ToOADate(); 
            chartArea.AxisX.Maximum = DateTime.Today.AddHours(22.5).ToOADate(); 
            chartArea.AxisX.Interval = 2;
            chartArea.AxisX.IntervalOffset = 0.5; 

            chartArea.AxisX.LabelStyle.Format = "h tt";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Hours;

            this.RevenueChart.BackColor = Color.FromArgb(27, 28, 30);
            this.RevenueChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.RevenueChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chartArea.AxisX.Title = "TIME (HOUR)";
            chartArea.AxisY.Title = "REVENUE ₱";
        }

        //DAILY REVENUE
        private void displayDailyRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            ResetChartArea();
            if (tbl == null || tbl.Rows.Count == 0) return;

            string[] daysOfWeek = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

            var sortedRevenue = tbl.AsEnumerable().OrderBy(row =>
            {
                string dayOfWeekFull = row.Field<string>("DayOfWeek");
                string dayOfWeek = dayOfWeekFull.Split('•')[1]?.Trim(); 
                return Array.IndexOf(daysOfWeek, dayOfWeek); 
            });

            Series splineSeries = new Series("Total Revenue")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.FromArgb(31, 178, 198),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            Series areaSeries = new Series("Gradient Area")
            {
                ChartType = SeriesChartType.SplineArea,
                BorderWidth = 0
            };
            areaSeries.BackGradientStyle = GradientStyle.TopBottom;

            foreach (var dayOfWeek in daysOfWeek)
            {
                var row = sortedRevenue.FirstOrDefault(r => r.Field<string>("DayOfWeek").Contains(dayOfWeek));
                double totalRevenue = row != null ? Convert.ToDouble(row["Revenue"]) : 0;

                // Map day of week to X-axis position
                int dayIndex = Array.IndexOf(daysOfWeek, dayOfWeek) + 1; // Adding 1 to match 1-based index of X-axis

                DataPoint dataPoint = new DataPoint(dayIndex, totalRevenue); // X-axis position starts from 1
                dataPoint.MarkerStyle = MarkerStyle.Circle; // Set marker style
                dataPoint.MarkerSize = 10; // Set marker size   
                dataPoint.BorderWidth = 2;
                dataPoint.MarkerSize = 10;
                splineSeries.Points.Add(dataPoint);
                areaSeries.Points.Add(dataPoint);
            }

            areaSeries.Color = Color.FromArgb(31, 178, 198);
            RevenueChart.Series.Add(splineSeries);
            RevenueChart.Series.Add(areaSeries);

            var chartArea = RevenueChart.ChartAreas[0];
            chartArea.AxisX.Minimum = 0.5;
            chartArea.AxisX.Maximum = 7.5; 
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.LabelStyle.Interval = 1; 
            chartArea.AxisX.LabelStyle.Enabled = true; 

            chartArea.AxisX.CustomLabels.Clear();
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                chartArea.AxisX.CustomLabels.Add(i + 0.5, i + 1.5, daysOfWeek[i]);
            }

            RevenueChart.BackColor = Color.FromArgb(27, 28, 30);
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            RevenueChart.ChartAreas[0].AxisX.LineColor = Color.White;
            RevenueChart.ChartAreas[0].AxisY.LineColor = Color.White;
            RevenueChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            RevenueChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            chartArea.AxisX.Title = "DAYS";
            chartArea.AxisY.Title = "REVENUE ₱";
        }


        //WEEKLY
        private void DisplayWeeklyRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            ResetChartArea();
            if (tbl == null || tbl.Rows.Count == 0) return;

            DateTime currentDate = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            int weeksInMonth = (int)Math.Min(Math.Ceiling((double)(lastDayOfMonth.Day + (int)firstDayOfMonth.DayOfWeek) / 7), 4);

            string[] weekLabels = new string[weeksInMonth];
            for (int i = 0; i < weeksInMonth; i++)
            {
                if (i == 0)
                {
                    weekLabels[i] = "1st week";
                }
                else if (i == 1)
                {
                    weekLabels[i] = "2nd week";
                }
                else if (i == 2)
                {
                    weekLabels[i] = "3rd week";
                }
                else
                {
                    weekLabels[i] = (i + 1) + "th week";
                }
            }

            Series splineSeries = new Series("Total Revenue")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.FromArgb(31, 178, 198),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            Series areaSeries = new Series("Gradient Area")
            {
                ChartType = SeriesChartType.SplineArea,
                BorderWidth = 0
            };
            areaSeries.BackGradientStyle = GradientStyle.TopBottom;

            for (int weekIndex = 0; weekIndex < weeksInMonth; weekIndex++)
            {
                if (weekIndex < tbl.Rows.Count)
                {
                    var row = tbl.Rows[weekIndex];
                    double totalRevenue = Convert.ToDouble(row["Revenue"]);

                    DataPoint dataPoint = new DataPoint(weekIndex + 1, totalRevenue);
                    dataPoint.MarkerStyle = MarkerStyle.Circle;
                    dataPoint.MarkerSize = 10;
                    dataPoint.BorderWidth = 2;
                    splineSeries.Points.Add(dataPoint);
                    areaSeries.Points.Add(dataPoint);
                }
                else
                {
                    DataPoint zeroDataPoint = new DataPoint(weekIndex + 1, 0);
                    splineSeries.Points.Add(zeroDataPoint);
                    areaSeries.Points.Add(zeroDataPoint);
                }
            }

            areaSeries.Color = Color.FromArgb(31, 178, 198);
            RevenueChart.Series.Add(splineSeries);
            RevenueChart.Series.Add(areaSeries);

            var chartArea = RevenueChart.ChartAreas[0];
            chartArea.AxisX.Minimum = 0.5; 
            chartArea.AxisX.Maximum = weeksInMonth + 0.5; 
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Interval = 1; 
            chartArea.AxisX.LabelStyle.Enabled = true;

            chartArea.AxisX.CustomLabels.Clear();
            for (int i = 0; i < weeksInMonth; i++)
            {
                chartArea.AxisX.CustomLabels.Add(i + 0.5, i + 1.5, weekLabels[i]);
            }
            
            RevenueChart.BackColor = Color.FromArgb(27, 28, 30);

            chartArea.AxisX.Title = "WEEKS";
            chartArea.AxisY.Title = "REVENUE ₱";
        }
        

        //MONTHLY
        private void DisplayMonthlyRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            ResetChartArea();
            if (tbl == null || tbl.Rows.Count == 0) return;

            int monthsInYear = 12; 

            string[] monthLabels = {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            Series splineSeries = new Series("Total Revenue")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.FromArgb(31, 178, 198),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10
            };

            Series areaSeries = new Series("Gradient Area")
            {
                ChartType = SeriesChartType.SplineArea,
                BorderWidth = 0
            };
            areaSeries.BackGradientStyle = GradientStyle.TopBottom;

            for (int monthIndex = 0; monthIndex < monthsInYear; monthIndex++)
            {
                DataRow[] rows = tbl.Select("MonthNumber = " + (monthIndex + 1));
                double totalRevenue = rows.Length > 0 ? Convert.ToDouble(rows[0]["Revenue"]) : 0;

                DataPoint dataPoint = new DataPoint(monthIndex + 1, totalRevenue);
                dataPoint.MarkerStyle = MarkerStyle.Circle;
                dataPoint.MarkerSize = 10;
                dataPoint.BorderWidth = 2;
                splineSeries.Points.Add(dataPoint);
                areaSeries.Points.Add(dataPoint);
            }

            areaSeries.Color = Color.FromArgb(31, 178, 198);
            RevenueChart.Series.Add(splineSeries);
            RevenueChart.Series.Add(areaSeries);

            var chartArea = RevenueChart.ChartAreas[0];
            chartArea.AxisX.Minimum = 0.5; 
            chartArea.AxisX.Maximum = monthsInYear + 0.5; 
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.LabelStyle.Interval = 1; 
            chartArea.AxisX.LabelStyle.Enabled = true; 

            chartArea.AxisX.CustomLabels.Clear();
            for (int i = 0; i < monthsInYear; i++)
            {
                chartArea.AxisX.CustomLabels.Add(i + 0.5, i + 1.5, monthLabels[i]);
            }

            RevenueChart.BackColor = Color.FromArgb(27, 28, 30);

            chartArea.AxisX.Title = "MONTHS";
            chartArea.AxisY.Title = "REVENUE ₱";

            foreach (DataRow row in tbl.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }

        //HOURLY QUERY
        private void todayRevenue()
        {
            MySqlConnection conn = DBConnection.getConnection();
            DateTime CurrentTime = DateTime.Now;
           
            try
            {
                conn.Open();

                string getListquery = "SELECT time_booked, ticket_total as Revenue FROM movies INNER JOIN bookings ON movies.movie_id = bookings.movie_id WHERE currentDate = @CurrentDate;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                getListcmd.Parameters.AddWithValue("CurrentDate", CurrentTime.ToString("dd/MM/yyyy • dddd"));
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                displayTodaysRevenueChart(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            // Adding and configuring the title
            Title chartTitle = new Title("CINÉVERSE'S HOURLY REVENUE")
            {
                Font = new Font("Montserrat", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            RevenueChart.Titles.Clear();
            RevenueChart.Titles.Add(chartTitle);
        }

        //DAILY QUERY
        private void DailyRevenue()
        {
            MySqlConnection conn = DBConnection.getConnection();
            DateTime currentDate = DateTime.Today;
            DateTime startDate = currentDate.AddDays(-(int)currentDate.DayOfWeek); // Start from Monday
            DateTime endDate = startDate.AddDays(6); // End on Sunday
            try
            {
                conn.Open();

                string getListquery = "SELECT currentDate AS DayOfWeek, SUM(ticket_total) AS Revenue FROM bookings WHERE currentDate BETWEEN @StartDate AND @EndDate GROUP BY currentDate;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                getListcmd.Parameters.AddWithValue("@StartDate", startDate.ToString("dd/MM/yyyy • dddd"));
                getListcmd.Parameters.AddWithValue("@EndDate", endDate.ToString("dd/MM/yyyy • dddd"));
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                displayDailyRevenueChart(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            Title chartTitle = new Title("CINÉVERSE'S DAILY REVENUE")
            {
                Font = new Font("Montserrat", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            RevenueChart.Titles.Clear();
            RevenueChart.Titles.Add(chartTitle);
        }

        //WEEKLY QUERY
        private void WeeklyRevenue()
        {
            MySqlConnection conn = DBConnection.getConnection();
            DateTime currentDate = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            try
            {
                conn.Open();

                string getListquery = @"
               SELECT 
                    WEEK(STR_TO_DATE(currentDate, '%d/%m/%Y')) AS WeekNumber, 
                    SUM(ticket_total) AS Revenue 
                FROM 
                    bookings 
                WHERE 
                    STR_TO_DATE(currentDate, '%d/%m/%Y') BETWEEN STR_TO_DATE(@StartDate, '%d/%m/%Y') AND STR_TO_DATE(@EndDate, '%d/%m/%Y')
                GROUP BY 
                    WEEK(STR_TO_DATE(currentDate, '%d/%m/%Y'));";

                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                getListcmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth.ToString("dd/MM/yyyy • dddd"));
                getListcmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth.ToString("dd/MM/yyyy • dddd"));
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Display the weekly revenue chart using the method
                DisplayWeeklyRevenueChart(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            Title chartTitle = new Title("CINÉVERSE'S WEEKLY REVENUE")
            {
                Font = new Font("Montserrat", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            RevenueChart.Titles.Clear();
            RevenueChart.Titles.Add(chartTitle);
        }

        //MONTHLY QUERY
        private void MonthlyRevenue()
        {
            MySqlConnection conn = DBConnection.getConnection();
            DateTime currentDate = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            try
            {
                conn.Open();

                string getListquery = @"
                SELECT 
                    MONTH(STR_TO_DATE(currentDate, '%d/%m/%Y')) AS MonthNumber, 
                    SUM(ticket_total) AS Revenue 
                FROM 
                    bookings 
                WHERE 
                    STR_TO_DATE(currentDate, '%d/%m/%Y') BETWEEN STR_TO_DATE(@StartDate, '%d/%m/%Y') AND STR_TO_DATE(@EndDate, '%d/%m/%Y')
                GROUP BY 
                    MONTH(STR_TO_DATE(currentDate, '%d/%m/%Y'))";

                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
                getListcmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth.ToString("dd/MM/yyyy • dddd"));
                getListcmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth.ToString("dd/MM/yyyy • dddd"));
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(getListcmd);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Display the monthly revenue chart using the method
                DisplayMonthlyRevenueChart(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            Title chartTitle = new Title("CINÉVERSE'S MONTHLY REVENUE")
            {
                Font = new Font("Montserrat", 20, FontStyle.Bold),
                ForeColor = Color.White,
                Alignment = ContentAlignment.TopCenter
            };

            RevenueChart.Titles.Clear();
            RevenueChart.Titles.Add(chartTitle);
        }

        //TODAY ONCLICK - DISPLAY PER TIME REVENUE
        private void btn_today_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(31, 178, 198);
            btn_today.ForeColor = Color.Black;

            btn_daily.BackColor = Color.FromArgb(20, 32, 32);
            btn_daily.ForeColor = Color.White;

            btn_weekly.BackColor = Color.FromArgb(20, 32, 32);
            btn_weekly.ForeColor = Color.White;

            btn_monthly.BackColor = Color.FromArgb(20, 32, 32);
            btn_monthly.ForeColor = Color.White;

            todayButtonisActive = true;
            dailyButtonisActive = false;
            weeklyButtonisActive = false;
            monthlyButtonisActive = false;

            todayRevenue();
            TodayStatisticsRevenue();
        }

        //DAILY ONCLICK - DISPLAY PER DAY REVENUE
        private void btn_daily_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;

            btn_daily.BackColor = Color.FromArgb(31, 178, 198);
            btn_daily.ForeColor = Color.Black;

            btn_weekly.BackColor = Color.FromArgb(20, 32, 32);
            btn_weekly.ForeColor = Color.White;

            btn_monthly.BackColor = Color.FromArgb(20, 32, 32);
            btn_monthly.ForeColor = Color.White;

            todayButtonisActive = false;
            dailyButtonisActive = true;
            weeklyButtonisActive = false;
            monthlyButtonisActive = false;

            DailyRevenue();
            TodayStatisticsRevenue();
        }

        //WEEKLY ONCLICK - DISPLAY PER WEEK REVENUE
        private void btn_weekly_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;

            btn_daily.BackColor = Color.FromArgb(20, 32, 32);
            btn_daily.ForeColor = Color.White;

            btn_weekly.BackColor = Color.FromArgb(31, 178, 198);
            btn_weekly.ForeColor = Color.Black;

            btn_monthly.BackColor = Color.FromArgb(20, 32, 32);
            btn_monthly.ForeColor = Color.White;

            todayButtonisActive = false;
            dailyButtonisActive = false;
            weeklyButtonisActive = true;
            monthlyButtonisActive = false;

            WeeklyRevenue();
            WeeklyStatisticsRevenue();
        }

        //MONTHLY ONCLICK - DISPLAY PER MONTH REVENUE
        private void btn_monthly_Click(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;

            btn_daily.BackColor = Color.FromArgb(20, 32, 32);
            btn_daily.ForeColor = Color.White;

            btn_weekly.BackColor = Color.FromArgb(20, 32, 32);
            btn_weekly.ForeColor = Color.White;

            btn_monthly.BackColor = Color.FromArgb(31, 178, 198);
            btn_monthly.ForeColor = Color.Black;

            todayButtonisActive = false;
            dailyButtonisActive = false;
            weeklyButtonisActive = false;
            monthlyButtonisActive = true;

            MonthlyRevenue();
            MonthlyStatisticsRevenue();
        }


        //TODAY'S STATISCTICS
        public void TodayStatisticsRevenue()
        {
            DateTime dateTime = DateTime.Now;
            MySqlConnection conn = DBConnection.getConnection();
            //getting total bookings
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_quantity) FROM bookings WHERE currentDate = @CurrentDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@CurrentDate", dateTime.ToString("dd/MM/yyyy • dddd"));
                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_totalTransactions.Text = "0";
                }
                else
                {
                    lbl_totalTransactions.Text = result.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally { conn.Close(); }


            //getting total revenue
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_total) FROM bookings WHERE currentDate = @CurrentDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@CurrentDate", dateTime.ToString("dd/MM/yyyy • dddd"));
                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_totalRevenue.Text = "₱0";
                }
                else
                {
                    double totalRev = Convert.ToDouble(result.ToString());
                    lbl_totalRevenue.Text = "₱" + totalRev.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally { conn.Close(); }
        }


        public void WeeklyStatisticsRevenue()
        {
            DateTime currentDate = DateTime.Now;
            MySqlConnection conn = DBConnection.getConnection();

            // Get the first and last day of the current week
            DateTime firstDayOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek);
            DateTime lastDayOfWeek = firstDayOfWeek.AddDays(6);

            // Get total bookings for the current week
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_quantity) FROM bookings WHERE currentDate BETWEEN @StartDate AND @EndDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@StartDate", firstDayOfWeek.ToString("dd/MM/yyyy • dddd"));
                cmd.Parameters.AddWithValue("@EndDate", lastDayOfWeek.ToString("dd/MM/yyyy • dddd"));

                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_totalTransactions.Text = "0";
                }
                else
                {
                    lbl_totalTransactions.Text = result.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving weekly statistics: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Get total revenue for the current week
            try
            {
                conn.Open();
                string getRevenueData = "SELECT SUM(ticket_total) FROM bookings WHERE currentDate BETWEEN @StartDate AND @EndDate;";
                MySqlCommand cmd = new MySqlCommand(getRevenueData, conn);
                cmd.Parameters.AddWithValue("@StartDate", firstDayOfWeek.ToString("dd/MM/yyyy • dddd"));
                cmd.Parameters.AddWithValue("@EndDate", lastDayOfWeek.ToString("dd/MM/yyyy • dddd"));
                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_totalRevenue.Text = "₱0";
                }
                else
                {
                    double totalRev = Convert.ToDouble(result.ToString());
                    lbl_totalRevenue.Text = "₱" + totalRev.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving weekly revenue: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        //MONTHLY REVENUE
        public void MonthlyStatisticsRevenue()
        {
            DateTime currentDate = DateTime.Now;
            MySqlConnection conn = DBConnection.getConnection();

            // Get the first and last day of the current month
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Get total bookings for the current month
            try
            {
                conn.Open();
                string getBookingsData = "SELECT SUM(ticket_quantity) FROM bookings WHERE currentDate BETWEEN @StartDate AND @EndDate;";
                MySqlCommand cmd = new MySqlCommand(getBookingsData, conn);
                cmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth.ToString("dd/MM/yyyy"));
                object result = cmd.ExecuteScalar();

                if (result.ToString().Equals(""))
                {
                    lbl_totalTransactions.Text = "0";
                }
                else
                {
                    lbl_totalTransactions.Text = result.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving monthly statistics: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Get total revenue for the current month
            try
            {
                conn.Open();
                string getRevenueData = "SELECT SUM(ticket_total) FROM bookings WHERE currentDate BETWEEN @StartDate AND @EndDate;";
                MySqlCommand cmd = new MySqlCommand(getRevenueData, conn);
                cmd.Parameters.AddWithValue("@StartDate", firstDayOfMonth.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@EndDate", lastDayOfMonth.ToString("dd/MM/yyyy"));
                object result = cmd.ExecuteScalar();

                double totalRevenue = result == DBNull.Value ? 0 : Convert.ToDouble(result);
                if (result.ToString().Equals(""))
                {
                    lbl_totalRevenue.Text = "₱0";
                }
                else
                {
                    double totalRev = Convert.ToDouble(result.ToString());
                    lbl_totalRevenue.Text = "₱" + totalRev.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving monthly revenue: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        //HOVER EFFECTS
        #region button Effects

        private void btn_today_MouseEnter(object sender, EventArgs e)
        {
            if (todayButtonisActive == false)
            {
                btn_today.BackColor = Color.FromArgb(31, 178, 198);
                btn_today.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_today_MouseLeave(object sender, EventArgs e)
        {
            if (todayButtonisActive == false)
            {
                btn_today.BackColor = Color.FromArgb(20, 32, 32);
                btn_today.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

   
        private void btn_daily_MouseEnter(object sender, EventArgs e)
        {
            if (dailyButtonisActive == false)
            {
                btn_daily.BackColor = Color.FromArgb(31, 178, 198);
                btn_daily.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_daily_MouseLeave(object sender, EventArgs e)
        {
            if (dailyButtonisActive == false)
            {
                btn_daily.BackColor = Color.FromArgb(20, 32, 32);
                btn_daily.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }


        

        private void btn_weekly_MouseEnter(object sender, EventArgs e)
        {
            if (weeklyButtonisActive == false)
            {
                btn_weekly.BackColor = Color.FromArgb(31, 178, 198);
                btn_weekly.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_weekly_MouseLeave(object sender, EventArgs e)
        {
            if (weeklyButtonisActive == false)
            {
                btn_weekly.BackColor = Color.FromArgb(20, 32, 32);
                btn_weekly.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

        

        private void btn_monthly_MouseEnter(object sender, EventArgs e)
        {
            if (monthlyButtonisActive == false)
            {
                btn_monthly.BackColor = Color.FromArgb(31, 178, 198);
                btn_monthly.ForeColor = Color.Black;
            }
            else
            {
                return;
            }
        }

        private void btn_monthly_MouseLeave(object sender, EventArgs e)
        {
            if (monthlyButtonisActive == false)
            {
                btn_monthly.BackColor = Color.FromArgb(20, 32, 32);
                btn_monthly.ForeColor = Color.White;
            }
            else
            {
                return;
            }
        }

        #endregion

        //EXIT BUTTON
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}