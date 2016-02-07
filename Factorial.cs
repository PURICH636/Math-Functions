using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial is : " + doFactorial(input));
            Console.ReadKey();
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
	}
}
