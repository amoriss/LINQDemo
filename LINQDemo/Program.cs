using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Examples of collections: 
            // 1) lists
            // 2) arrays


            //collection 1
            List<Person> people = ListManager.LoadSimpleData();
            people = people.OrderBy(x => x.LastName).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($" {person.FirstName} {person.LastName} : Years of Experience {person.YearsOfExperience}");
            }

            //collection 2
            var array = new int[] {1, 24, 29, 30, 42, 302};

            //foreach loop

            //using LINQ

        }
    }
}
