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
        public AssociatedPerson Director { get; private set; }
        public List<AssociatedPerson> Actors { get; private set; }
        public string Genre { get; private set; }

        /// <summary>
        /// If all information is provided
        /// </summary>
        public bool Full  { get; private set; } 

        public Movie(int movieID, string title)
        {
            MovieID = movieID;
            Title = title;
            Full = false;
        }

        public Movie(int movieID, string title, bool? isAdult, int? runTime, int? releaseYear, float? rating, AssociatedPerson director, List<AssociatedPerson> actors, string genre)
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
            Full = true;
        }

        public override string ToString() => Title;
    }
}
