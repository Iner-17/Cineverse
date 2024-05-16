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
        private void displayRevenueChart(DataTable tbl)
        {
            RevenueChart.Series.Clear();
            if (tbl == null) return;

            var sortedRevenue = tbl.AsEnumerable().OrderBy(row => row.Field<String>("time_booked")); 


            Series splineSeries = new Series("Total Revenue")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 2,
                Color = Color.FromArgb(31, 178, 198),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 5
            };

            Series areaSeries = new Series("Gradient Area")
            {
                ChartType = SeriesChartType.SplineArea,
                BorderWidth = 0
            };
            areaSeries.BackGradientStyle = GradientStyle.TopBottom;
            foreach (var row in sortedRevenue)
            {
                String date = row.Field<String>("time_booked");
                double totalRevenue = row.Field<double>("Revenue");

                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = date.ToString();
                dataPoint.SetValueXY(date, totalRevenue);

                splineSeries.Points.AddXY(date.ToString(), totalRevenue);
                areaSeries.Points.AddXY(date.ToString(), totalRevenue);
                revenueDataPoints.Add(dataPoint);
            }
            areaSeries.Color = System.Drawing.Color.FromArgb(31, 178, 198);
            RevenueChart.Series.Add(splineSeries);
            RevenueChart.Series.Add(areaSeries);
            
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = "SELECT title, time_booked, seats_booked, ticket_quantity, ticket_total as Revenue FROM movies INNER JOIN bookings ON movies.movie_id = bookings.movie_id;";
                MySqlCommand getListcmd = new MySqlCommand(getListquery, conn);
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
    }
}
