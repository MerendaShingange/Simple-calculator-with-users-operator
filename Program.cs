using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator_with_users_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter an operator");
            string op = Console.ReadLine();
            Console.WriteLine("enter a second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (op == "-")
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
            else
            {
                Console.WriteLine("not an operator");
            }
            Console.Read();
        }
    }
}
