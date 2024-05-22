using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cineverse
{
    internal class TimeINOUT
    {
        public static int user_id = 0;

        //METHOD SET TIME IN
        public static void TimeIn()
        {

            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
                string getTimeInquery = "INSERT INTO employee (user_id, time_in) VALUES (@User_id, @Time_in)";
                MySqlCommand getTimeCmd = new MySqlCommand(getTimeInquery, conn);
                getTimeCmd.Parameters.AddWithValue("User_id", user_id);
                getTimeCmd.Parameters.AddWithValue("Time_in", string.Format("{0:hh:mm:ss tt}", DateTime.Now).ToUpper());
                getTimeCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        //METHOD SET TIMEOUT
        public static void TimeOut()
        {
            int latestId = 0;
            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
                string getLatestId = "SELECT id FROM employee ORDER BY id DESC LIMIT 1";
                MySqlCommand getLatestIdcmd = new MySqlCommand(getLatestId, conn);

                MySqlDataReader reader = getLatestIdcmd.ExecuteReader();

                while (reader.Read())
                {
                    latestId = Convert.ToInt32(reader["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

            try
            {
                conn.Open();
                string saveTimeOut = "UPDATE employee SET time_out = @CurrentTime WHERE id = @Id AND time_out IS NULL";
                MySqlCommand getTimeoutcmd = new MySqlCommand(saveTimeOut, conn);
                getTimeoutcmd.Parameters.AddWithValue("CurrentTime", string.Format("{0:hh:mm:ss tt}", DateTime.Now).ToUpper());
                getTimeoutcmd.Parameters.AddWithValue("Id", latestId);
                getTimeoutcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "asd");

            }
            finally { conn.Close(); }
        }

    }
}
