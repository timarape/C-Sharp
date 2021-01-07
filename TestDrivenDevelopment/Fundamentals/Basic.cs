using System;
using System.Collections.Generic;
using System.Text;

namespace Fundamentals
{
    public class Basic
    {
        public int DivideNumbers(int firstnumber, int secondNumber)
        {
            if (secondNumber == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            return firstnumber / secondNumber;
        }

        public string Swap(int firstNumber, int secondNumber)
        {

          return string.Concat(secondNumber.ToString(), firstNumber.ToString());
        }
    }
}
