using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;

namespace SEWebapplicatieIMDB.Classes
{
    public class DBMovies :DatabaseConnection
    {
        public List<Movie> GetAllMovies()
        {

            List<Movie> MovieList = new List<Movie>();
            string sql = "SELECT * FROM DBS2_Movie";
            try
            {

                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
              

                OracleDataReader DataRead = cmd.ExecuteReader();

                while(DataRead.Read())
                {
                    int Movie_ID = Convert.ToInt32(DataRead["MOVIE_ID"]);
                    string Title = Convert.ToString(DataRead["Title"]);
                    int Duration = Convert.ToInt32(DataRead["DURATION"]);
                    double Rating = Convert.ToDouble(DataRead["Rating"]);
                    string Director = Convert.ToString(DataRead["Director"]);
                    int RelatedMovieId = Convert.ToInt32(DataRead["RelatedmovieID"]);
                    string Storyline =  Convert.ToString(DataRead["Storyline"]);
                    string Category = Convert.ToString(DataRead["Category"]);

                    Movie movie = new Movie(Movie_ID, Title, Duration,  Rating,  Director,RelatedMovieId, Storyline, Category);
                    MovieList.Add(movie);
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

            return MovieList;
        }

    }
}