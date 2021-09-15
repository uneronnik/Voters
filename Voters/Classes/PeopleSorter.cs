﻿using System;
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

        public void SortByAlphabet(bool ascendingOrder = true)
        {
            if(ascendingOrder)
                _peopleToSort.Sort((left, right) => left.Surname.CompareTo(right.Surname));
            else
                _peopleToSort.Sort((left, right) => right.Surname.CompareTo(left.Surname));
        }
    }
}
