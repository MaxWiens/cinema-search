using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    public class AssociatedPerson
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string CharacterName { get; private set; }

        public AssociatedPerson(int id, string name, string characterName, bool isDirector)
        {
            Name = name;
            CharacterName = characterName;
            ID = id;
        }

        public override string ToString()
        {
            if (CharacterName != null)
                return Name + " as " + CharacterName;
            else
                return Name;
        }

        public override bool Equals(object p)
        {
            if (p.GetType() == typeof(AssociatedPerson))
                return ID == ((AssociatedPerson)p).ID;
            return base.Equals(p);
        }
    }
}
