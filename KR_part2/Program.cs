using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Person : IComparable
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return Name + " : " + Age;
            }

            public int CompareTo(object a)
            {
                Person p = a as Person;
                if (this.Age.Equals(p.Age))
                    return this.Name.CompareTo(p.Name);
                else
                    return this.Age.CompareTo(p.Age);
            }
        }


        static void Main(string[] args)
        {
            Person A = new Person("Max", 21);
            Person B = new Person("Den",27);
            Person C = new Person ("Andrey",  19);
            Person D = new Person ( "Max", 23);
            Person E = new Person ("Alex", 21);

            Person[] people = new Person[] {A, B, C, D, E};

            Array.Sort(people);

            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}