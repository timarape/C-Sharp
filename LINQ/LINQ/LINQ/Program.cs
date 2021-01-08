using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction();

            LinqOnObjects();

            Console.ReadLine();
        }

        private static void LinqOnObjects()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Thepiso","Marape", 110, 70, Gender.Male),
                new Person("Thabo","Morena", 120, 87, Gender.Male),
                new Person("Mike","Manzini", 150, 89, Gender.Male),
                new Person("Thapelo","Selahle", 120, 66, Gender.Male),

                new Person("Simon","Nkosi", 88, 64, Gender.Male),

                new Person("Maria","Baloi", 190, 54, Gender.Female),

                new Person("Suzan","Masire", 33, 55, Gender.Female),

                new Person("Lerato","Zwide", 80, 60, Gender.Female),

                new Person("Fatti","Smith", 77, 45, Gender.Female),

                new Person("Stones","McDonalds", 90, 77, Gender.Male),

                new Person("Fab","Koloi", 132, 88, Gender.Female),

                new Person("Steven","Schols", 180, 66, Gender.Male),

                new Person("Kelly","Bright", 200, 60, Gender.Female)

            };


            var allFemales = from fmale in people
                             where fmale.Gender == Gender.Female
                             select fmale.FirstName;

            Console.WriteLine(string.Join(", ",allFemales));
        }

        private static void Introduction()
        {
            string text = "I love my dog";

            string[] dogNames = { "Thabiso", "Mike", "Sello", "Tshepo", "Ike", "Athalia", "Light", "Wamp" };
            int[] numbers = { 3, 4, 5, 6, 67, 4, 3, 23, 23, 23, 23, 3, 34, 54, 5, 65, 654, 4, 54, 3, 23, 234, 3, 5, 445, 45 };

            var getNumbers = from number in numbers
                             where number > 50
                             select number;

            var getNames = from name in dogNames
                           where name.StartsWith('T')
                           select name;


            Console.WriteLine(string.Join(", ", getNames));
        }
    }
}
