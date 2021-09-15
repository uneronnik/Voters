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
            List<Person> adultPeople = new List<Person>();

            foreach (var person in _people)
            {
                if (person.IsAdult())
                    adultPeople.Add(person);
            }

            _people = adultPeople;
        }

        public void SelectByAddress(string address)
        {
            List<Person> selectedPeople = new List<Person>();

            foreach (var person in _people)
            {
                if(person.Address == address)
                    selectedPeople.Add(person);
            }

            _people = selectedPeople;
        }
    }
}
