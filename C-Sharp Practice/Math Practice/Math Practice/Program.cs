using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multplies users input by 50.
            Console.WriteLine("Please enter a number:");
            double input1 = double.Parse(Console.ReadLine());
            double result1 = input1 * 50;
            Console.WriteLine($"Result of multiplying {input1} by 50 is {result1}");

            // Adds users input by 25.
            Console.WriteLine("Please enter another number:");
            double input2 = double.Parse(Console.ReadLine());
            double result2 = input2 + 25;
            Console.WriteLine($"Result of adding 25 to {input2} is {result2}");

            // Divides users input by 12.5.
            Console.WriteLine("Please enter another number:");
            double input3 = double.Parse(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine($"Result of dividing {input3} by 12.5 is {result3}");

            // Checks to see if the users input is greater than 50.
            Console.WriteLine("Plese enter another number:");
            double input4 = double.Parse(Console.ReadLine());
            bool result4 = input4 > 50;
            Console.WriteLine($"Is {input4} greater than 50? {result4}");

            // Divides users input by 7 and prints the remainder.
            Console.WriteLine("Please enter one last number:");
            double input5 = double.Parse(Console.ReadLine());
            double result5 = input5 % 7;
            Console.WriteLine($"The remainder of dividing {input5} by 7 is {result5}");
            Console.ReadLine();
        }
    }
}
