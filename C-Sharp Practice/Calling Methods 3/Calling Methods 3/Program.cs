using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This will instantiate the class.
            Calculator calculator = new Calculator();

            // This will ask the user to input two numbers, one at a time.
            Console.WriteLine("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number (optional): ");
            string secondNumberString = Console.ReadLine();

            // This calls the method in the class, passing in the one or two numbers entered.
            if (string.IsNullOrEmpty(secondNumberString))
            {
                int result = calculator.mathOperation(firstNumber);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                int secondNumber = int.Parse(secondNumberString);
                int result = calculator.mathOperation(firstNumber, secondNumber);
                Console.WriteLine("Result: " + result);
            }
            Console.ReadLine();
        }
    }
}
