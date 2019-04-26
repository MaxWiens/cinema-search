using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class Actor
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int BirthYear { get; private set; }

        public Actor(int id, string name, int birthYear)
        {
            ID = id;
            Name = name;
            BirthYear = birthYear;
        }
    }
}
