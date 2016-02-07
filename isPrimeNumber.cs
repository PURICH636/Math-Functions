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
            //Console.Write("Input Number: ");
            //input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 1000; i++)
            {
                if(isPrimeNumber(i, i-1))
                    Console.WriteLine(i + " is Prime Number");
            }
            Console.ReadKey();
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
    }

}
