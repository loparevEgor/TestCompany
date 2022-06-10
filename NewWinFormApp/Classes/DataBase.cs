using System;
using System.Drawing;
using System.Windows.Forms;
using Company;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NewWinFormApp
{
    static class DataBase
    {
        public static SqlConnection sqlConnection;

        public static void OpenConnection()
        {
            if(sqlConnection != null && sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
        }
        
        public static void CloseConnection()
        {
            if(sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
        }

        public static void ActivateConnection()
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Егор\RiderProjects\NewWinFormApp\NewWinFormApp\DataBase.mdf;Integrated Security=True");
        }
    }
    
}
