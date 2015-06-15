using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEWebapplicatieIMDB.Classes;

namespace Unit_test_IMDB
{
    [TestClass]
    public class MovieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Movie MovieTest = new Movie(1,"Testfilm",120,7.7,"Pietjan",1,"bla bla storyline","Drama");
            Assert.AreEqual(1, MovieTest.Movie_ID,"Movie_ID incorrect (Test)");
            Assert.AreEqual("Testfilm", MovieTest.Title,"Title is incorrect (Test)");
            Assert.AreEqual(120, MovieTest.Duration,"Duration is incorrect (Test)");
            Assert.AreEqual(7.7,MovieTest.Rating,"Rating is incorrect (Test)");
            Assert.AreEqual("Pietjan",MovieTest.Director,"Title is incorrect (Test)");
            Assert.AreEqual(1,MovieTest.RelatedMovieID,"RelatedMovieID is incorrect (Test)");
            Assert.AreEqual("bla bla storyline",MovieTest.Storyline,"Storyline is incorrect (Test)");
            Assert.AreEqual("Drama",MovieTest.Category,"Category is incorrect (Test)");





        }
    }
}
