using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace SEWebapplicatieIMDB.Classes
{
    public class DBAccount :DatabaseConnection
    {
        public bool Insert(Account account)
        {
            bool ishetgelukt = false;

            string sql = "INSERT INTO Account(Firstname,Lastname,Gender,Yearofbirth,Country,Postalcode,Email,Rol,Username,Password) VALUES (:FirstName, :LastName, :Gender, :YearOfBirth, :Country, :PostalCode, :Email, :Rol, :UserName, :Password)";
            try
            {

                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("FirstName", account.FirstName));
                cmd.Parameters.Add(new OracleParameter("LastName",account.LastName));
                cmd.Parameters.Add(new OracleParameter("Gender",account.Gender));
                cmd.Parameters.Add(new OracleParameter("YearOfBirth",account.YearOfBirth));
                cmd.Parameters.Add(new OracleParameter("Country",account.Country));
                cmd.Parameters.Add(new OracleParameter("PostalCode", account.PostalCode));
                cmd.Parameters.Add(new OracleParameter("Email", account.EMail));
                cmd.Parameters.Add(new OracleParameter("Rol","Geregistreerd" ));
                cmd.Parameters.Add(new OracleParameter("UserName", account.UserName));
                cmd.Parameters.Add(new OracleParameter("Password", account.Password));

                ishetgelukt = true;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                this.connection.Close();
            }

            return ishetgelukt;
        }
    }
}