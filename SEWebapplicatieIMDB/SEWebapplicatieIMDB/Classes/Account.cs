using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string Country { get; set; }
        public String PostalCode { get; set; }
        public string EMail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Account(string firstname, string lastname, string gender, DateTime yearofbirth, string country, string postalcode, string email, string username, string password)
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
    }
}