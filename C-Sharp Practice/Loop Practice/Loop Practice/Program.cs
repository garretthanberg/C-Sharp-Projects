using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("This is a while loop:");

            // While loop boolean comparison.
            while (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
                num1++;
                Console.ReadLine();
            }

            Console.WriteLine("This is a do-while loop:");

            // Do-While loop boolean comparison.
            int count = 0;

            do // This means do at least once.
            {
                Console.WriteLine($"The count is {count}");
                count++;
                Console.ReadLine();
            }
            while (count < 5); // This will loop while count is less than 5.
        }
    }
}
