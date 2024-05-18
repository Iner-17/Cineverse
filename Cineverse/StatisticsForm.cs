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

namespace Cineverse
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
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

        private void displayRevenueChart(DataTable tbl)
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
                MarkerSize = 10
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
            chartArea.AxisX.Minimum = DateTime.Today.AddHours(9.5).ToOADate(); // Add a 30-minute offset to 10 AM
            chartArea.AxisX.Maximum = DateTime.Today.AddHours(22.5).ToOADate(); // Extend the axis to 10:30 PM
            chartArea.AxisX.Interval = 2;
            chartArea.AxisX.IntervalOffset = 0.5; // Ensure labels start correctly

            chartArea.AxisX.LabelStyle.Format = "hh tt";
            chartArea.AxisX.IntervalType = DateTimeIntervalType.Hours;

            this.RevenueChart.BackColor = Color.FromArgb(27, 28, 30);
            this.RevenueChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.RevenueChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void displayWeeklyRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            ResetChartArea();
            if (tbl == null || tbl.Rows.Count == 0) return;

            string[] daysOfWeek = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

            var sortedRevenue = tbl.AsEnumerable().OrderBy(row =>
            {
                string dayOfWeekFull = row.Field<string>("DayOfWeek");
                string dayOfWeek = dayOfWeekFull.Split('•')[1]?.Trim(); // Extracting the day of the week portion
                return Array.IndexOf(daysOfWeek, dayOfWeek); // Sort based on the index of the day in the daysOfWeek array
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
            chartArea.AxisX.Minimum = 0.5; // Slightly before Sunday
            chartArea.AxisX.Maximum = 7.5; // Slightly after Saturday
            chartArea.AxisX.Interval = 1; // 1 day interval
            chartArea.AxisX.LabelStyle.Interval = 1; // Show labels for each day
            chartArea.AxisX.LabelStyle.Enabled = true; // Enable custom labels

            // Customize X-axis labels
            chartArea.AxisX.CustomLabels.Clear();
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                chartArea.AxisX.CustomLabels.Add(i + 0.5, i + 1.5, daysOfWeek[i]);
            }

            // Customize chart appearance
            RevenueChart.BackColor = Color.FromArgb(27, 28, 30);
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
            RevenueChart.ChartAreas[0].AxisX.LineColor = Color.White;
            RevenueChart.ChartAreas[0].AxisY.LineColor = Color.White;
            RevenueChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            RevenueChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

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

                displayRevenueChart(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void weeklyRevenue()
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

                displayWeeklyRevenueChart(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            todayRevenue();
        }

        private void btn_thisWeek_Click(object sender, EventArgs e)
        {
            weeklyRevenue();
        }
    }
}