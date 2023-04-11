using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Log_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string input = Console.ReadLine(); // This reads user input as string.
            File.WriteAllText("numbers.txt", input); // This writes the number to a text file.
            Console.WriteLine($"Number logged to file. Here are the contents of the file: {File.ReadAllText("numbers.txt")}"); // This prints the contents of the file to the console.
            Console.ReadLine(); // This waits for user input before closing the console app.
        }
    }
}
