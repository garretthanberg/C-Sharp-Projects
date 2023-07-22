using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This creates a one-dimensional array of strings.
            string[] stringArray = { "apple", "banana", "cherry", "orange" };

            // This asks the user to select an index of the array.
            Console.Write("Enter an index of the string array: ");
            int index = int.Parse(Console.ReadLine());

            // This displays the string at that index on the screen.
            if (index >= 0 && index < stringArray.Length)
            {
                Console.WriteLine($"The string at index {index} is \"{stringArray[index]}\".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Index {index} does not exist in the string array.");
                Console.ReadLine();
            }

            // This creates a one-dimensional array of integers.
            int[] intArray = { 1, 3, 5, 7, 9 };

            // This asks the user to select an index of the array.
            Console.Write("Enter an index of the integer array: ");
            index = int.Parse(Console.ReadLine());

            // This displays the integer at that index on the screen.
            if (index >= 0 && index < intArray.Length)
            {
                Console.WriteLine($"The integer at index {index} is {intArray[index]}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Index {index} does not exist in the integer array.");
                Console.ReadLine();
            }

            // This creates a list of strings.
            List<string> stringList = new List<string> { "red", "orange", "yellow", "green", "blue", "purple" };

            // This asks the user to select an index of the list.
            Console.Write("Enter an index of the string list: ");
            index = int.Parse(Console.ReadLine());

            // This displays the content at that index on the screen.
            if (index >= 0 && index < stringList.Count)
            {
                Console.WriteLine($"The string at index {index} is \"{stringList[index]}\".");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Index {index} does not exist in the string list.");
                Console.ReadLine();
            }
        }
    }
}
