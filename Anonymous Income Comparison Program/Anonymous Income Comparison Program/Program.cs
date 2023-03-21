using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            // This collects the hourly rate for Person #1.
            Console.WriteLine("Person #1");
            Console.Write("Hourly Rate: ");
            double hourlyRate1 = double.Parse(Console.ReadLine());

            // This collects how many hours worked for Person #1.
            Console.Write("Hours worked per week: ");
            double hoursPerWeek1 = double.Parse(Console.ReadLine());

            // This collects the hourly rate for Person #2.
            Console.WriteLine("Person #2");
            Console.Write("Hourly Rate: ");
            double hourlyRate2 = double.Parse(Console.ReadLine());

            // This collect how many hours worked for Person #2.
            Console.Write("Hours worked per week: ");
            double hoursPerWeek2 = double.Parse(Console.ReadLine());

            // This calculates the annual salary by multiplying the hourly rate by the hours worked each week, then by 52 weeks.
            double annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

            // This prints the annual salary for Person #1 and #2 to the console.
            Console.WriteLine("Annual salary of Person #1: $" + annualSalary1.ToString("N2")); // "N2" is a format specifier that shows two decimal places.
            Console.WriteLine("Annual salary of Person #2: $" + annualSalary2.ToString("N2")); 

            // This compares the annual salary of both people to see if Person #1 makes more money than Person #2.
            bool makesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person #1 make more money than Person #2? " + makesMore);
            Console.ReadLine();
        }
    }
}
