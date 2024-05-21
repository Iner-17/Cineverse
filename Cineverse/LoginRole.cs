using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cineverse
{
    internal class LoginRole
    {
        public static int GlobalRole = 0;


        public static int GetRole(string username, string password)
        {
            int role = 0;

            MySqlConnection conn = DBConnection.getConnection();
            try
            {
                conn.Open();
                string checkRole = "SELECT role FROM accounts WHERE username = @Username AND password = @Password";
                MySqlCommand cmd = new MySqlCommand(checkRole, conn);
                cmd.Parameters.AddWithValue("Username", username);
                cmd.Parameters.AddWithValue("Password", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    role = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            finally { conn.Close(); }

            return role;
        }
    }
}
