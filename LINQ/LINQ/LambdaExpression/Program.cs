using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 's', "Hello Kitty", 1, 2, 3, 4, };

            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;

            var evenNumbersLambda = numbers.Where(n => (n % 2 == 0));

            var avarageCatNamesLength = catNames.Average(c => c.Length);

            var allIntergers = mix.OfType<int>().Where(i => i < 5);


            //numbers.ForEach(n => Console.WriteLine($"{n}"));

            Console.WriteLine(string.Join(" ", evenNumbersLambda));



            Console.ReadLine();
        }
    }
}
