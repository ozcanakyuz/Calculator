using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            string operation;
            int result = 0;
            Console.Write("First Number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Addition + Subtraction - Multiplication * Division / : ");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                result = number1 + number2;
                Console.WriteLine("Result: " + result);
                Console.ReadKey();
            }
            else if (operation == "-")
            {
                result = number1 - number2;
                Console.WriteLine("Result: " + result);
                Console.ReadKey();
            }
            else if (operation == "*")
            {
                result = number1 * number2;
                Console.WriteLine("Result: " + result);
                Console.ReadKey();
            }
            else if (operation == "/")
            {
                result = number1 / number2;
                Console.WriteLine("Result: " + result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("ERROR!");
                Console.ReadKey();
            }
        }
    }
}
