using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voters.Classes
{
    class PeopleSorter
    {
        List<Person> _peopleToSort = new List<Person>();

        public PeopleSorter(List<Person> peopleToSort)
        {
            _peopleToSort = peopleToSort;
        }

        internal List<Person> People { get => _peopleToSort; }

        public List<Person> SortByAlphabet(bool ascendingOrder = true)
        {
            if (ascendingOrder)
                _peopleToSort = (from person
                                in _peopleToSort
                                 orderby person.Surname ascending
                                 select person).ToList();
            else
                _peopleToSort = (from person
                                in _peopleToSort
                                 orderby person.Surname descending
                                 select person).ToList();
            return _peopleToSort;
        }
    }
}
