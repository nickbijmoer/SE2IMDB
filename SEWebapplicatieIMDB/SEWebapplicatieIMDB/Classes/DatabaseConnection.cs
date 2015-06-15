using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    //Databaseconnection class used to make a connection to the database
    using Oracle.DataAccess.Client;
    public class DatabaseConnection
    {

        protected OracleConnection connection = new OracleConnection();
        //Athena server 
        protected string connectionString = "DATA SOURCE=192.168.15.50:1521/fhictora;PASSWORD=dbi324529;USER ID=ZaozMNrus2";
        //Used for local database, use this if Athena database is not working, i had some trouble with the athena database that i couldnt connect to it with cisco anyconnect
        //protected string connectionString = "DATA SOURCE=//localhost:1521/xe;PASSWORD=mark;USER ID=mark";


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