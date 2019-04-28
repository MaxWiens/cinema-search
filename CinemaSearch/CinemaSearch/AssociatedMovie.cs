using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    public class AssociatedMovie
    {
        public string Title { get; private set; }
        public int ID { get; private set; }
        public string Character { get; private set; }
        public bool IsDirector { get; private set; }

        public AssociatedMovie(string title, int id, string character, bool isDirector)
        {
            Title = title;
            ID = id;
            Character = character;
            IsDirector = isDirector;
        }

        public override string ToString() => Title;
    }
}
