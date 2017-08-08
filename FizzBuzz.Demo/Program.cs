using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Demo");
            Console.WriteLine();
            var data = FizzBuzz.SolveForRange(1, 100);

            foreach(string item in data)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
