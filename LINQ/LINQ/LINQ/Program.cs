using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I love my dog";

            string[] dogNames = { "Thabiso", "Mike", "Sello", "Tshepo", "Ike", "Athalia", "Light", "Wamp" };
            int[] numbers = { 3, 4, 5, 6, 67, 4, 3, 23, 23, 23, 23, 3, 34, 54, 5, 65, 654, 4, 54, 3, 23, 234, 3, 5, 445, 45 };

            //var suffixOnames = from dogNames

            var getNumbers = from number in numbers
                             select number;

            var getNames = from dog in dogNames
                           select dog;


            var startWithTNames = from dogName in dogNames
                                  where dogName.StartsWith('T')
                                  select dogName;



            Console.WriteLine(string.Join(",", startWithTNames));

            //Console.WriteLine(string.Join(",", getNumbers));

            Console.ReadLine();
        }
    }
}
