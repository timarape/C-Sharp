using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(AreEqual(2,2));

            Console.ReadLine();
        }



        static bool AreEqual<T>(T fistNumber, T secondNumber) where T: IComparable<T>
        {

            return fistNumber.CompareTo(secondNumber) == 0;

        }
    }
}
