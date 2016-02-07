using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is " + doFibonacci(input));
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

        public static long doFactorial(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return number * doFactorial(number - 1);
            }
        }

        public static bool isPrimeNumber(int number, int denominator)
        {
            if (number <= 3 || denominator == 1)
            {
                return true;
            }
            else
            {
                if (number % denominator == 0)
                {
                    return false;
                }
                return isPrimeNumber(number, denominator - 1);
            }
        }

        public static double pow(double a, double b)
        {
            if (b > 0)
            {
                return mul(a, pow(a, b-1));
            }
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return div(1, mul(a, pow(a, b - 1)));
            }
        }

        public static double mul(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            else
            {
                return a + mul(a, b-1);
            }
        }

        public static double div(double a, double b)
        {
            if(a < b)
            {
                return 0;
            }
            if(a == 0 && b ==0)
            {
                Console.WriteLine("The number is indeterminable");
                return 0;
            }
            if (b == 0)
            {
                return 0;
            }
            if(a - b == 0)
            {
                return 1;
            }
            else
            {
                return div(a - b, b) + 1;
            }
        }
    }

}
