using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    //This is the businesslayer, used because I implement the 3 layer structure
    public class BusinessLayer
    {
   
        private DBAccount dbAccount = new DBAccount();
        private DBMovies dbMovies = new DBMovies();

        public bool Registreren(Account newaccount)
        {
            return this.dbAccount.Insert(newaccount);
        }
        public Account login(string Gebruikersnaam, string Password)
        {
            Account LoginAccount = this.dbAccount.Login(Gebruikersnaam, Password);
            return LoginAccount;
            
        }

        public bool ChangePassword(int UserID, string password)
        {
            return this.dbAccount.ChangePassword(UserID, password);
        }

        public List<Movie> GetAllMovies()
        {
            return this.dbMovies.GetAllMovies();
        }

        public List<Movie> GetTop10Movies()
        {
            return this.dbMovies.GetTop10Movies(); 
        }


        public bool DeleteMovie(int MovieID)
        {
            return this.dbMovies.DeleteMovie(MovieID);
        }
    }
}