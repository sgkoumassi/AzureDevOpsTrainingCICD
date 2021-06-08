using System;
using System.Text;

namespace TDDNUnit
{
     public class FizzBuzz
    {
       public string  generate(int minNumber, int maxNumber)
        {


            return evaluateNumbers(minNumber, maxNumber);

        }

        private string evaluateNumbers(int minNumber, int maxNumber)
        {
            StringBuilder FizzBuzz1To100 = new StringBuilder();
            while (minNumber <= maxNumber)
                FizzBuzz1To100.Append(evaluateNumber(minNumber++));
            return FizzBuzz1To100.ToString();
        }

        private string evaluateNumber(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();

        }
    }
}
