using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This gets the current date and time.
            DateTime currentTime = DateTime.Now;

            // This prints the current date and time to the console.
            Console.WriteLine("Current Date and Time: " + currentTime);

            // This asks the user for a number.
            Console.WriteLine("Enter a number: ");
            int hours = int.Parse(Console.ReadLine());

            // This calculates the time X (The number entered) hours from now.
            DateTime futureTime = currentTime.AddHours(hours);

            // This prints the future time to the console.
            Console.WriteLine("Future Time: " + futureTime);

            Console.ReadLine();
        }
    }
}
