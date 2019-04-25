using DataAccess;
using CinemaSearch.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CinemaSearch.DataDelegates
{
   public class RetrieveMoviesDataDelegate : DataReaderDelegate<IReadOnlyList<Movie>>
   {
      public RetrieveMoviesDataDelegate()
         : base("Movie.RetrieveMovies")
      {
      }

      public override IReadOnlyList<Movie> Translate(SqlCommand command, SqlDataReader reader)
      {
         var movies = new List<Movie>();

         while (reader.Read())
         {
            movies.Add(new Movie(
               reader.GetInt32(reader.GetOrdinal("MovieID")),
               reader.GetString(reader.GetOrdinal("Title")),
               reader.GetBoolean(reader.GetOrdinal("IsAdult")),
               reader.GetInt32(reader.GetOrdinal("Runtime")),
               reader.GetInt32(reader.GetOrdinal("ReleaseYear"))
               ));
         }

         return movies;
      }
   }
}