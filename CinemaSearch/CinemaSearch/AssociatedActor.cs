using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class AssociatedActor
    {
        public string Name { get; private set; }
        public int ID { get; private set; }

        public AssociatedActor(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public override string ToString() => Name;
    }
}
