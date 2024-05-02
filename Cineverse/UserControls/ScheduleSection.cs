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

namespace Cineverse.UserControls
{
    public partial class ScheduleSection : UserControl
    {
        public ScheduleSection()
        {
            InitializeComponent();
        }

        private void ScheduleSection_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.getConnection();

            try
            {
                conn.Open();

                string getListquery = "SELECT title, date, start_time FROM movies INNER JOIN screening ON movies.movie_id = screening.movie_id;";
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

        private void lbl_refresh_MouseEnter(object sender, EventArgs e)
        {
            lbl_refresh.ForeColor = Color.FromArgb(31, 178, 198);
        }

        private void lbl_refresh_MouseLeave(object sender, EventArgs e)
        {
            lbl_refresh.ForeColor = Color.White;
        }

        private void btn_today_MouseEnter(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(31, 178, 198);
            btn_today.ForeColor = Color.Black;
        }

        private void btn_today_MouseLeave(object sender, EventArgs e)
        {
            btn_today.BackColor = Color.FromArgb(20, 32, 32);
            btn_today.ForeColor = Color.White;
        }

        private void btn_thisWeek_MouseEnter(object sender, EventArgs e)
        {
            btn_thisWeek.BackColor = Color.FromArgb(31, 178, 198);
            btn_thisWeek.ForeColor = Color.Black;
        }

        private void btn_thisWeek_MouseLeave(object sender, EventArgs e)
        {
            btn_thisWeek.BackColor = Color.FromArgb(20, 32, 32);
            btn_thisWeek.ForeColor= Color.White;
        }
    }
}
