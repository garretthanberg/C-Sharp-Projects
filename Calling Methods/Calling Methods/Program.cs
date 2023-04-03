using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This will ask the user for the input.
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            // This creates an instance of the MathOperations class.
            MathOperations mathOps = new MathOperations();

            // This calls each method in turn and displays the results.
            int doubled = mathOps.Double(userInput);
            Console.WriteLine("Doubled: " + doubled);

            int squared = mathOps.Square(userInput);
            Console.WriteLine("Squared: " +  squared);

            int divided = mathOps.Divide(userInput);
            Console.WriteLine("Divided by 2: " + divided);

            // This will wait for the user to press a key before closing the console.
            Console.ReadLine();
        }
    }
}
