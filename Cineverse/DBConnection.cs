using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Cineverse
{
    internal class DBConnection
    {

        private static readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cineversedb;";

        public static MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;

            
        }
    }
}
