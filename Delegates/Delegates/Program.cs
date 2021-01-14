using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    class Program
    {
        public delegate bool Filters(string item);

        static void Main(string[] args)
        {
            string[] names = { "Tshepiso", "Ike", "Bridget", "Tshepang", "Mike", "Lerato", "Portia", "Jane", "Bobby", "Sharon" };

           var newnames = NamesFilter(names, LessThanFive);

            Console.WriteLine(string.Join("",newnames)); 

            Console.ReadLine();
        }

        public static bool LessThanFive(string name)
        {
            return name.Length < 5;

        }

        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;

        }


        public static bool EqualsFive(string name)
        {
            return name.Length == 5;

        }


        public static List<string> NamesFilter(string[] items, Filters filter)
        {
            return  (from item in items
                                     where filter(item)
                                     select item).ToList();

        }
    }
}
