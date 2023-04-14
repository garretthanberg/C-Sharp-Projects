using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This asks the user for their age.
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    throw new Exception("Age must be a positive number.");
                }

                // This displays the year the user was born.
                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;
                Console.WriteLine($"You were born in {birthYear}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using AgeCalculator.");
            }
            Console.ReadLine();
        }
    }
}
