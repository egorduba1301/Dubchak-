using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_4
{
    public class PersonDatabase
    {
        public List<Person> Persons { get; set; }

        public PersonDatabase()
        {
            Persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            Persons.Add(person);
        }

        public List<Person> FindPersonsByAgeRange(int minAge, int maxAge)
        {
            var result = new List<Person>();
            foreach (var person in Persons)
            {
                if (person.GetAge() >= minAge && person.GetAge() <= maxAge)
                {
                    result.Add(person);
                }
            }
            return result;
        }

        public void PrintInfo()
        {
            foreach (var person in Persons)
            {
                person.PrintInfo();
                Console.WriteLine();
            }
        }
    }
}