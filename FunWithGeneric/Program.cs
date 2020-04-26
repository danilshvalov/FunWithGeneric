using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericList();
            Console.WriteLine();
            UseGenericStack();
            Console.WriteLine();
            UseGenericQueue();
            Console.WriteLine();
            UseSortedSet();
            Console.WriteLine();
            UseDictionary();

            Console.ReadLine();
        }
        static void UseGenericList()
        {
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };

            Console.WriteLine($"Items in list: {people.Count}");
            Console.WriteLine();

            Console.WriteLine("*** List: ***");
            foreach (Person item in people)
                Console.WriteLine(item);
            Console.WriteLine("*************");
            Console.WriteLine();

            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
            Console.WriteLine($"Now count is {people.Count}");
            Console.WriteLine();

            Person[] arrayOfPeople = people.ToArray();
            foreach (Person item in arrayOfPeople)
                Console.WriteLine(item);
        }
        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            // Последний добавленный элемент можно узнать через .Peek();
            Console.WriteLine($"First person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped of {stackOfPeople.Pop()}");

            Console.WriteLine($"First person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped of {stackOfPeople.Pop()}");

            Console.WriteLine($"First person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Poped of {stackOfPeople.Pop()}");

            try
            {
                Console.WriteLine($"First person is {stackOfPeople.Peek()}");
                Console.WriteLine($"Poped of {stackOfPeople.Pop()}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }

        }
        static void GetCoffee(Person person)
        {
            Console.WriteLine($"{person.FirstName} got coffee!");
        }
        static void UseGenericQueue()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleQ.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
            peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

            Console.WriteLine($"First is {peopleQ.Peek().FirstName}");

            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }
        }
        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age = 47},
                new Person {FirstName = "Marge", LastName = "Simpson", Age = 45},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9},
                new Person {FirstName = "Bart", LastName = "Simpson", Age = 8}
            };
            foreach (Person item in setOfPeople)
                Console.WriteLine(item);

            Console.WriteLine();

            setOfPeople.Add(new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });

        }
        static void UseDictionary()
        {
            Dictionary<string, Person> peopleDict = new Dictionary<string, Person>()
            {
                { "Homer", new Person {FirstName = "Homer", LastName = "Simpson", Age = 47} },
                { "Marge", new Person {FirstName = "Marge", LastName = "Simpson", Age = 45} },
                { "Lisa", new Person {FirstName = "Lisa", LastName = "Simpson", Age = 9} }
            };

            Console.WriteLine($"Homer is \"{peopleDict["Homer"]}\"");
        }


    }

}
