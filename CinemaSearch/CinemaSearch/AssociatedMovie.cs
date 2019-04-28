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

        public AssociatedMovie(int id, string title, string character, bool isDirector)
        {
            Title = title;
            ID = id;
            Character = character;
            IsDirector = isDirector;
        }

        public override string ToString()
        {
            if (IsDirector && Character != null)
                return $"Director and Actor in {Title} as {Character}";
            else if (IsDirector)
                return $"Director of {Title}";
            else if (Character != null)
                return $"Actor in {Title} as {Character}";
            else
                return "Actor in" + Title;
        }
    }
}
