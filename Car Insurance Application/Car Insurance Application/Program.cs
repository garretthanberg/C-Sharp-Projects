using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s see if you qualify for car insurance.");
            // This asks the user for their age and stores the input in a variable.
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            // This asks the user if they have ever had a DUI and stores the input in a variable.
            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            // This asks the user how many speeding tickets they have had and stores the input in a variable.
            Console.WriteLine("How many speeding tickets do you have?");
            int numSpeedingTickets = Convert.ToInt32(Console.ReadLine());

            // If all of the following criteria is met than the user qualifies for car insurance.
            bool isQualified = (age > 15 && !hasDUI &&  numSpeedingTickets <= 3);

            // This prints the result pf the boolean expression above.
            Console.WriteLine("Did you qualify?");
            Console.WriteLine(isQualified);

            // This waits for the users input before closing the program.
            Console.ReadLine();
        }
    }
}
