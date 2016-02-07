using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fiboonacci
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial is : " + doFibonacci(input));
            Console.ReadKey();
        }

        public static long doFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return doFibonacci(number - 1) + doFibonacci(number - 2);
            }
        }
    }

}
