using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEWebapplicatieIMDB.Classes
{
    public class Movie
    {
        public int Movie_ID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; }
        public int RelatedMovieID { get; set; }
        public string Storyline { get; set; }
        public string Category { get; set; }

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