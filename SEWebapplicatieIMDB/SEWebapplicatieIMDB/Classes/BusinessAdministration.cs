using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    public class BusinessAdministration
    {
        private DBAccount dbAccount = new DBAccount();

        public bool Registreren(Account newaccount)
        {
            return this.dbAccount.Insert(newaccount);
        }
        public Account login(string Gebruikersnaam, string Password)
        {
            return this.dbAccount.GebruikerLogin(Account);
        }
    }
}