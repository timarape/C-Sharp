using System;

namespace MathLibrary
{
    public class Calculator
    {
        public int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Max(int firstNumber, int secondnumber)
        {
            return (firstNumber > secondnumber) ? firstNumber : secondnumber;
        }
            
    }
}
