using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    public class Person
    {
        public int PersonID { get; private set; }
        public string Name { get; private set; }
        public int? BirthYear { get; private set; }
        public List<AssociatedMovie> Movies { get; private set; }

        public Person(int personID, string name)
        {
            PersonID = personID;
            Name = name;
        }

        public Person(int personID, string name, int? birthYear, List<AssociatedMovie> movies)
        {
            PersonID = personID;
            Name = name;
            BirthYear = birthYear;
            Movies = movies;
        }

        public override string ToString() => Name;
    }
}
