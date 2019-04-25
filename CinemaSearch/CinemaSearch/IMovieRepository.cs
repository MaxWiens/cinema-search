using System.Collections.Generic;
using CinemaSearch.Models;

namespace CinemaSearch
{
    interface IMovieRepository
    {
        IReadOnlyList<Movie> RetrieveMovies();

        Movie GetMovie(int MovieID);
        
        //Movie CreateMovie(int MovieID, string Title, bool? IsAdult, int? Runtime, int? ReleaseYear);
    }
}
