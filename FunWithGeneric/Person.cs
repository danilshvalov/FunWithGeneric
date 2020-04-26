using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGeneric
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string name, string surname, int age)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
        }
        public override string ToString() => $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
