using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class Movie
    {
        public int MovieID { get; private set; }
        public string Title { get; private set; }
        public bool? IsAdult { get; private set; }
        public int? Runtime { get; private set; }
        public int? ReleaseYear { get; private set; }
        public float? Rating { get; private set; }
        public Person Director { get; private set; }
        public List<AssociatedActor> Actors { get; private set; }
        //Genre Genre;

        public Movie(int movieID, string title, bool? isAdult, int? runTime, int? releaseYear, float? Rating)
        {
            MovieID = movieID;
            Title = title;
            IsAdult = isAdult;
            Runtime = runTime;
            ReleaseYear = releaseYear;
        }

        public override string ToString() => Title;
    }
}
