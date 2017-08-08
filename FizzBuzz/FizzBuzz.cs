using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string Solve(int number)
        {
            bool fizz = number % 3 == 0;
            bool buzz = number % 5 == 0;

            if (fizz && buzz)
                return "FizzBuzz";
            else if (fizz)
                return "Fizz";
            else if (buzz)
                return "Buzz";
            else
                return number.ToString();
        }

        public static List<string> SolveForRange(int start, int end)
        {
            var result = new List<string>();

            for(var i = start; i <= end; i++)
            {
                result.Add(Solve(i));
            }

            return result;
        }
    }
}
