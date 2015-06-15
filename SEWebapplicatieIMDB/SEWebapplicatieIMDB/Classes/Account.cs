using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    //Account class used for accounts
    public class Account
    {
        //all properties
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int YearOfBirth { get; set; }
        public string Country { get; set; }
        public String PostalCode { get; set; }
        public string EMail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        //Account constructor used for making new Accounts and put them in a list
        public Account(string firstname, string lastname, string gender, int yearofbirth, string country, string postalcode, string email, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            YearOfBirth = yearofbirth;
            Country = country;
            PostalCode = postalcode;
            EMail = email;
            UserName = username;
            Password = password;
        }

        //Constructor used for sessions
        public Account(int userid, string gebruikersnaam, string rol)
        {
            Rol = rol;
            UserID = userid;
            UserName = gebruikersnaam;
        }
    }
}