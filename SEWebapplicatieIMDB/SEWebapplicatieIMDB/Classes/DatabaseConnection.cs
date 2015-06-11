using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    using Oracle.DataAccess.Client;
    public class DatabaseConnection
    {

        protected OracleConnection connection = new OracleConnection();
        protected string connectionString = "DATA SOURCE=//localhost:1521/xe;PASSWORD=mark;USER ID=mark";


        public DatabaseConnection()
        {

        }

        public void Connect()
        {
            try
            {
                connection = new OracleConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch
            {
                connection.Close();
            }
        }

        public void DisConnect()
        {
            connection.Close();
            connection.Dispose();
        }
    }
    

}