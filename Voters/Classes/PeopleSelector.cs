using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voters.Classes
{
    class PeopleSelector
    {
        List<Person> _people = new List<Person>();

        public PeopleSelector(List<Person> people)
        {
            _people = people;
        }

        internal List<Person> People { get => _people; }

        public void SelectAdultPeople()
        {
            _people = (from person 
                       in _people 
                       where person.IsAdult == true 
                       select person).ToList();

        }

        public void SelectByAddress(string address)
        {
            _people = (from person
                       in _people
                       where person.Address == address
                       select person).ToList();
        }
    }
}
