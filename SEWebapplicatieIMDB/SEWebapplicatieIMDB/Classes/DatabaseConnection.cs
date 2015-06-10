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
        protected string connectionString = "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421";


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