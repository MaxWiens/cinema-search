using CinemaSearch.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace CinemaSearch.DataDelegates
{
    internal class GetMovieDataDelegate : DataReaderDelegate<Movie>
    {
        private int MovieID { get; }

        public GetMovieDataDelegate(int personId)
           : base("Movie.GetMovie")
        {
            this.MovieID = MovieID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var m = command.Parameters.Add("MovieID", SqlDbType.Int);
            m.Value = MovieID;
        }

        public override Movie Translate(SqlCommand command, SqlDataReader reader)
        {
            if (!reader.Read())
                return null;

            return new Movie (
               reader.GetInt32(reader.GetOrdinal("MovieID")),
               reader.GetString(reader.GetOrdinal("Title")),
               reader.GetBoolean(reader.GetOrdinal("IsAdult")),
               reader.GetInt32(reader.GetOrdinal("Runtime")),
               reader.GetInt32(reader.GetOrdinal("ReleaseYear"))
               );
        }
    }
}