using System.Collections.Generic;
using DataAccess;
using CinemaSearch.Models;
using CinemaSearch.DataDelegates;
using System;

namespace CinemaSearch
{
    class SqlMovieRepository : IMovieRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlMovieRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
        /*
        public Person CreatePerson(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(lastName));

            var d = new CreatePersonDataDelegate(firstName, lastName);
            return executor.ExecuteNonQuery(d);
        }
        */
        public Movie GetMovie(int personId)
        {
            var d = new GetMovieDataDelegate(personId);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Movie> RetrieveMovies()
        {
            return executor.ExecuteReader(new RetrieveMoviesDataDelegate());
        }
    }
}
