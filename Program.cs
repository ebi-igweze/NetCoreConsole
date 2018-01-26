using System;
using System.Collections.Generic;
using System.Linq;

namespace consoleApp
{

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }


    // Functions in .Net C#
    class Functions
    {

        public static void Main(string args)
        {
            var person = new Person { name = "Chuks", age = 54 };
            var person2 = new Person();

            person2.name = "Chuks";
            person2.age = 54;
            var personAge = person.age; //  54;
            var func = new Functions();
            func.AddFive(4); // 9
            var init = func.initial; // 23
            var count = Functions.count; // 55
            var ints = new int[] { 1, 2, 5 };
            var intsByFive = ints.Select(func.AddFive); // func.AddFive(5);
            var intsByFiveA = ints.Select((x) => { return x + 5; });
            var intsByFiveAS = ints.Select((x) => x + 5);
        }

        public static int count = 55;
        public int initial = 23;
        public int AddFive(int x)
        {
            var result = x + 5;
            return x + 5;
        }
    }

    public class Program
    {

        public static void Main(string[] array)
        {

            var people = new List<Person> {
            new Person { name = "Wini", age = 44 },
            new Person { name = "lola", age = 45 },
            new Person { name = "Ebi", age = 16 },
        };

            var teenagersNames =
                people.Where((p) => { return p.age < 19 && p.age > 12; })
                      .Where(p => p.name.EndsWith("e"))
                      .Skip(3)
                      .Take(5)
                      .Select(p => new { name = p.name + " " + p.age })
                      .ToList();

            var teenagersNamesQ =
                from p in people
                where (p.age < 19 && p.age > 12)
                where p.name.EndsWith("e")
                select new { name = p.name + " " + p.age };

            var teenagersNamesQList = teenagersNamesQ.ToList();

        }

    }
}