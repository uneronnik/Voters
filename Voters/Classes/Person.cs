using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voters.Interfaces;

namespace Voters.Classes
{
    class Person : IWritable
    {
        string _name;
        string _surname;
        string _address;
        DateTime _birthDay;
        public string Name { get => _name; }
        public string Surname { get => _surname; }
        public string Address { get => _address; }
        public DateTime BirthDay { get => _birthDay; }

        public bool IsAdult()
        {
            DateTime now = DateTime.Now;
            TimeSpan eighteenYears = now.AddYears(18) - now;

            if (DateTime.Now - _birthDay > eighteenYears)
                return true;
            return false;
        }

        public Person(string name, string surname, string address, DateTime birthDay)
        {
            _name = name;
            _surname = surname;
            _address = address;
            _birthDay = birthDay;
        }

        void IWritable.WriteData()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Фамилия: {_surname}");
            Console.WriteLine($"Адрес: {_address}");
            Console.WriteLine($"Дата рождения: {_birthDay.ToShortDateString()}");
        }
    }
}
