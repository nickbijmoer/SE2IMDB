using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    //Movie class, used to store all the movie information
    public class Movie
    {
        public int Movie_ID { get; set; } // is the ID of the movie in the database
        public string Title { get; set; } // Title of the movie
        public int Duration { get; set; } // duration in minutes
        public double Rating { get; set; } // rating with 1 decimal (ex. 8.8)
        public string Director { get; set; } // director of movie
        public int RelatedMovieID { get; set; } // movieID of related movie
        public string Storyline { get; set; } // storyline of the movie
        public string Category { get; set; }// category of movie

        public Movie(int movieId, string title, int duration, double rating, string director, int relatedMovieId, string storyline, string category)
        {
            Movie_ID = movieId;
            Title = title;
            Duration = duration;
            Rating = rating;
            Director = director;
            RelatedMovieID = relatedMovieId;
            Storyline = storyline;
            Category = category;
        }
    }

}