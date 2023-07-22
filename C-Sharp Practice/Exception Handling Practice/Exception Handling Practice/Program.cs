using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This creates a list of integers.
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            try
            {
                // This asks the user for a number to divide each number in the list by.
                Console.WriteLine("Enter a number to divide each number in the list by: ");
                int dividingNumber = Convert.ToInt32(Console.ReadLine());

                // This is a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                foreach (int num in numbers)
                {
                    Console.WriteLine($"{num} / {dividingNumber} = {num / dividingNumber}");
                }
            }
            catch (FormatException ex)
            {
                // This will display the error message if the user enters a non-integer string.
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // This will display the error message if the user enters zero as the dividingNumber.
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // This will print a message to the display to let the user know the program has emerged from the try/block and continued on with program execution.
                Console.WriteLine("Program has continued on with execution.");

                // This will wait for the user to press a key to exit the program.
                Console.ReadLine();
            }
        }
    }
}
