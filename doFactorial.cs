using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class doFactorial
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial is : " + factorial(input));
            Console.ReadKey();
        }

        public static long factorial(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }
	}
}
