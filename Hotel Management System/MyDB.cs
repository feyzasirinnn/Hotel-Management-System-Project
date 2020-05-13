using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    class MyDB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306; user=root;password=EFeyza301019;database=hotel_management_system");
        public void OpenConnection()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State==System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
