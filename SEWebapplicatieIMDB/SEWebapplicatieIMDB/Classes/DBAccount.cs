using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace SEWebapplicatieIMDB.Classes
{
    public class DBAccount :DatabaseConnection
    {
        int account_ID;
        string gebruikersnaam;
        string Rol;

        public bool Insert(Account account)
        {
            bool ishetgelukt = false;

            string sql = "INSERT INTO DBS2_Account(Account_ID,Firstname,Lastname,Gender,Yearofbirth,Country,Postalcode,Email,Rol,Username,Password) VALUES (:Account_ID,:FirstName, :LastName, :Gender, :YearOfBirth, :Country, :PostalCode, :Email, :Rol, :UserName, :Password)";
            try
            {

                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("Account_ID", 4));
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

        public Account Login(string Gebruikersnaam, string Password)
        {
            

            string sql = "SELECT account_ID,Gebruikersnaam,Rol FROM DBS2_ACCOUNT WHERE Gebruikersnaam = :Gebruikersnaam AND Password = :Password"; 
            try
            {

                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("Gebruikersnaam", Gebruikersnaam));
                cmd.Parameters.Add(new OracleParameter("Password", Password));

                OracleDataReader DataRead = cmd.ExecuteReader();

                if (DataRead.HasRows)
                {
                 account_ID   = Convert.ToInt32(reader["ACCOUNT_ID"]);
                 gebruikersnaam = Convert.ToInt32(reader["GEBRUIKERSNAAM"]);
                 Rol = Convert.ToInt32(reader["ROL"]);

                Account LoginAccount = new Account(account_ID,gebruikersnaam,Rol);
                }
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

            return Loginaccount;
        }
    }
}