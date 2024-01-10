using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Simple_Calculator_With_User_s_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "_")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "%")
            {
                Console.WriteLine(num1 / num2);
            }

            else
            {

                Console.WriteLine("Not an operator");
            }

            Console.Read();
        }
    }
}

