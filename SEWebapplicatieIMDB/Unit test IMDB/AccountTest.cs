using System;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEWebapplicatieIMDB.Classes;

namespace Unit_test_IMDB
{
    [TestClass]
    public class TestAccount
    {
        [TestMethod]
        public void TestAccountMethod()
        {
          Account testaccount = new Account("Nick","Bijmoer","Male",1996,"Nederland","4854ER","nick@bijmoer.nl","Nickb","Nickb123");
          Assert.AreEqual("Nick", testaccount.FirstName, "Firstname is incorrect (Test)");
          Assert.AreEqual("Bijmoer",testaccount.LastName,"Last name is incorrect (Test)");
          Assert.AreEqual("Male",testaccount.Gender,"Gender is incorrect (test)");
          Assert.AreEqual(1996,testaccount.YearOfBirth,"Year of Birth is incorrect (Test)");
          Assert.AreEqual("Nederland",testaccount.Country,"Country is incorect (Test)");
          Assert.AreEqual("4854ER", testaccount.PostalCode,"Postalcode is incorrect (Test)");
          Assert.AreEqual("nick@bijmoer.nl",testaccount.EMail,"Email is incorrect (Test)");
          Assert.AreEqual("Nickb",testaccount.UserName,"Username incorrect (Test)");
          Assert.AreEqual("Nickb123", testaccount.Password, "Password is incorrect (Test)");
        }
    }
}
