using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This prompts the user to enter the current day of the week.
                Console.WriteLine("Enter the current day of the week: ");
                string input = Console.ReadLine();

                // This parses the user input as an enum value and assigns it to a variable.
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);

                // This prints the current day of the week to the console.
                Console.WriteLine("Today is {0}.", currentDay);
            }
            catch (ArgumentException)
            {
                // This catches an ArgumentException that may occur due to invalid input.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
    // This creates an enum for the days of the week.
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
