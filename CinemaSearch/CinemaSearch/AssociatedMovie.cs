using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class AssociatedMovie
    {
        public string Title { get; private set; }
        public int ID { get; private set; }

        public AssociatedMovie(string title, int id)
        {
            Title = Title;
            ID = id;
        }

        public override string ToString() => Title;
    }
}
