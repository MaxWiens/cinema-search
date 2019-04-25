using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class Movie
    {
        int MovieID;
        string Title;
        bool? IsAdult;
        int? Runtime;
        int? ReleaseYear;
        Person Director;
        //Genre Genre;
        //Director Director;

        public Movie(int movieID, string title, bool? isAdult, int? runTime, int? releaseYear)
        {
            MovieID = movieID;
            Title = title;
            IsAdult = isAdult;
            Runtime = runTime;
            ReleaseYear = releaseYear;
            
        }
    }
}
