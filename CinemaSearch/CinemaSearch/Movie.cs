using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    public class Movie
    {
        public int MovieID { get; private set; }
        public string Title { get; private set; }
        public bool? IsAdult { get; private set; }
        public int? Runtime { get; private set; }
        public int? ReleaseYear { get; private set; }
        public float? Rating { get; private set; }
        public Person Director { get; private set; }
        public List<AssociatedPerson> Actors { get; private set; }
        public string Genre { get; private set; }

        public Movie(int movieID, string title)
        {
            MovieID = movieID;
            Title = title;
        }

        public Movie(int movieID, string title, bool? isAdult, int? runTime, int? releaseYear, float? rating, Person director, List<AssociatedPerson> actors, string genre)
        {
            MovieID = movieID;
            Title = title;
            IsAdult = isAdult;
            Runtime = runTime;
            ReleaseYear = releaseYear;
            Rating = rating;
            Director = director;
            Actors = actors;
            Genre = genre;
        }

        public override string ToString() => Title;
    }
}
