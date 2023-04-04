using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice
{
    static class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the Divider class();
            Divider divider = new Divider();

            // This has the user enter a number.
            Console.WriteLine("Enter a number: ");

            // This reads the number from the user input.
            int num = int.Parse(Console.ReadLine());

            // This calls the divideBy2 method on that number.
            divider.divideBy2(num);

            // This calls the multiplyBy2 method with output parameters.
            int product;
            int result1 = divider.multiplyBy2(num, out product);
            Console.WriteLine($"The result of multiplying {num} by 2 is {result1}, and the product is {product}");

            // This calls the overloaded multipltBy2 method.
            int result2 = divider.multiplyBy2(num);
            Console.WriteLine($"The result of overloading the method to multiply {num} by 2 is {result2}");

            Console.ReadLine();
        }
    }
}
