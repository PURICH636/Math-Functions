using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class doCalculate
    {
        static void Main(string[] args)
        {
            double input1, input2, ans = 0;
            char op;
            Console.Write("Enter first number: ");
            input1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            input2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the operator (*, /, ^): ");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '*': ans = mul(input1, input2);
                    break;
                case '/': ans = div(input1, input2);
                    break;
                case '^': ans = pow(input1, input2);
                    break;
            }
            if(input1 == ' ' || input2 == ' ' || op == ' ')
            {
                Console.WriteLine("Invalid operator!");
            }
            else
            {
                Console.WriteLine("{0} {1} {2} = {3}", input1, op, input2, ans);
            }
            Console.ReadKey();
        }

        public static double pow(double a, double b)
        {
            if (b > 0)
            {
                return mul(a, pow(a, b-1));
            }
            else
            {
                return 1;
            }
        }

        public static double mul(double a, double b)
        {
            if (b == 0)
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
            else
            {
                return div(a - b, b) + 1;
            }
        }
    }

}
