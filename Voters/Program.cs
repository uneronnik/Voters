using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voters.Classes;

namespace Voters
{
    class Program
    {
        static void WritePersonCollection(ICollection<Person> people)
        {
            foreach (var person in people)
            {
                person.WriteData();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {

            List<Person> cityResidents = new List<Person>();

            cityResidents.Add(new Person("Nikita", "Mazov", "Улица Пушкина, дом колотушкина", new DateTime(1999, 7, 21)));
            cityResidents.Add(new Person("Andrey", "Ivanov", "Улица Пушкина, дом колотушкина", new DateTime(1980, 5, 3)));
            cityResidents.Add(new Person("Petr", "Petrov", "Улица Пушкина, дом колотушкина", new DateTime(2013, 5, 19)));
            cityResidents.Add(new Person("Petr", "Petrov", "Улица Гоголя, дом мой", new DateTime(1970, 7, 5)));

            PeopleSelector peopleSelector = new PeopleSelector(cityResidents);
            peopleSelector.SelectByAddress("Улица Пушкина, дом колотушкина"); 
            peopleSelector.SelectAdultPeople(); // Выбираем из жителей города совершеннолетних по одному адресу

            List<Person> voters = new List<Person>();
            voters = peopleSelector.People; // Нужно только для того, чтобы имена переменных совпадало с содержанием

            PeopleSorter peopleSorter = new PeopleSorter(voters);

            peopleSorter.SortByAlphabet(); // Сортируем по алфавиту

            WritePersonCollection(voters);

            

            
            Console.ReadKey();
        }
    }
}
