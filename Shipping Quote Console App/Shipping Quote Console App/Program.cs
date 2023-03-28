using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // This p[rompts the user to enter package weight.
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // This checks if the package is too heavy to be shipped.
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // This will end the program when any key is clicked.
            }

            // This will promp the user to enter package dimensions.
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // This will calculate the package dimensions total.
            int dimensionsTotal = width + height + length;

            // This will check if the package is too big to be shipped.
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return; // This will end the program when any key is clicked.
            }

            // This will calculate the shipping quote.
            int quote = (width * height * length * weight) / 100;

            // This will display the quote to the user.
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote}.00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
