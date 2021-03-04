using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.models
{
    public class DataBaseModel
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-OBD3GI2\\SQLEXPRESS;Database=Data1(kurs2);Trusted_Connection=True");
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
