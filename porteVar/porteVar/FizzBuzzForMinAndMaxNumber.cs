using System;
using System.Collections.Generic;
using System.Text;

namespace porteVar
{
    class FizzBuzzForMinAndMaxNumber
    {
        public static string generate(int minNumber, int maxNumber)
        {


            return evaluateNumbers(minNumber, maxNumber);

        }

        public static string evaluateNumbers(int minNumber, int maxNumber)
        {
            StringBuilder FizzBuzz1To100 = new StringBuilder();
            while (minNumber <= maxNumber)
                FizzBuzz1To100.Append(evaluateNumber(minNumber++));
            return FizzBuzz1To100.ToString();
        }

        public static string evaluateNumber(int number)
        {
            if (number % 15 == 0) return "FizzBuzz";
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return number.ToString();

        }
    }
}
