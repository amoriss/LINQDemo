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

            //sort by last name
            //people = people.OrderByDescending(x => x.LastName).ToList();


            ////filter where first names have greater than length of 3
            //var nameLength = people.Where(x => x.FirstName.Length > 3);

            ////filter where employees have years of experience greater than 6
            //var yoeGreaterThan6 =people.Where(x => x.YearsOfExperience > 6).OrderBy(x => x.LastName);

            //Console.WriteLine("Ordered by Last Name Descending");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($" {person.FirstName} {person.LastName} : Years of Experience {person.YearsOfExperience}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Name length greater than 3: ");
            //foreach (var item in nameLength)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //Console.WriteLine("Employees with years of experience greater than 6");
            //foreach (var item in yoeGreaterThan6)
            //{
            //    Console.WriteLine($"{item.FullName} YOE: {item.YearsOfExperience}");
            //}


            //Find the average years of experience
            var averageExperience = people.Average(p => p.YearsOfExperience);
            Console.WriteLine($"Average years of experience {averageExperience}");

            //checking existence
            var hasSenior = people.Any(p => p.YearsOfExperience > 10);
            Console.WriteLine($"Anyone that has greater than 10 years of experience: {hasSenior}");

            //conditional statement -- Find the first person (if any) with the last name "Smith".
            var smith = people.FirstOrDefault(p => p.LastName == "Smith");
            Console.WriteLine($"Person with the last name Smith: {smith.FullName}");


            Console.WriteLine("First Names that start with M");
            //if first name starts with an M
            people.Where(x => x.FirstName.StartsWith("M")).ToList().ForEach(x => Console.WriteLine(x.FirstName));

            
            
            
            
            




            
            
            
            
            
            //collection 2

            var array = new int[] {1, 24, 29, 30, 42, 302};
            
            //foreach loop

            //foreach (var item in array)
            //{ 
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            ////using LINQ

            //var filtered = array.Where(num => num % 2 == 0);
            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);
            //}












           //array.Where(x => x %2 ==0).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
