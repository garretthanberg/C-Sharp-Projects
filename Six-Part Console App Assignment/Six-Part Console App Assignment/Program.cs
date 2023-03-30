using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six_Part_Console_App_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Part 1:
            // This declares and initializes the array of strings.
            string[] testArray = { "Hello", "World", "This", "Is", "A", "Test" };

            // This asks the user to input some text.
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            // This will loop through each string in the array above and add the user's input to the end of each string.
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] += userInput;
            }

            // This will print each string in the updated array.
            foreach (string str in testArray)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();

            // Assignment Part 2:
            // This declares a counter variable and initializes it to 0.
            int counter = 0;

            // This is a while loop that will execute as long as the counter is less than 10.
            while (counter < 10)
            {
                // This will print the value of the counter to the console.
                Console.WriteLine("Counter value: " + counter);

                // This will fix the infinite loop by incrementing the counter by 1.
                counter++;
            }
            // This will wait for the user to press any ket before continuing to the next assignment.
            Console.ReadLine();

            // Assignment Part 3:
            // This is a loop with a "<" operator.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop with a \"<\" operator: " + i);
            }

            // This is a loop with a "<=" operator.
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine("Loop with a \"<=\" operator: " + j);
            }
            Console.ReadLine();

            // Assignment Part 4:
            // This creats a list of strings.
            List<string> items = new List<string>() { "apple", "banana", "orange", "grape", "pineapple" };

            // This asks the user to input text to search for an item.
            Console.WriteLine("Enter text to search for: ");
            string searchText = Console.ReadLine();

            // This initializes a flag to indicate whether a match has been found or not.
            bool matchFound = false;

            // This loops through each item in the list and checks if it contains the search text.
            for (int i = 0; i< items.Count; i++)
            {
                if (items[i].Contains(searchText))
                {
                    Console.WriteLine("Match found at index " + i);
                    matchFound = true;
                    break;
                }
            }

            // This will check if a match was not found and inform the user.
            if (!matchFound)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();

            // Assignment Part 5:
            // This will create a list of strings with some duplicate items.
            List<string> stringList = new List<string>() { "apple", "banana", "orange", "banana", "pear" };

            // This asks the user to input a text to search for an item.
            Console.WriteLine("Enter text to search for: ");
            string search = Console.ReadLine();

            // This sets a flag to track whether or not a match has been found.
            bool foundMatch = false;

            // This loops through each item in the list.
            for (int i = 0; i < stringList.Count; i++)
            {
                // If the current item matches the user's input, it will print the index of the item and set the flag to true.
                if (stringList[i] == search)
                {
                    Console.WriteLine("Match found at index {0}.", i);
                    foundMatch = true;
                }
            }

            // If a match was not found, this will print a message indicating so.
            if (!foundMatch)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            // This will wait for the user to press a key before going on to the last assignment.
            Console.ReadLine();

            // Assignment Part 6:
            // This creates a list of strings with at least two identical items.
            List<string> names = new List<string>() { "Garrett", "Aliza", "Abel", "Ryan", "Garrett", "Aliza", "Haily" };

            // This creats a new hashset to keep track of which names have already appeared in the list.
            HashSet<string> uniqueNames = new HashSet<string>();

            // This loops through each item in the list using a foreach loop.
            foreach (string name in names)
            {
                // This checks if the current string has already appeared in the list before.
                if (uniqueNames.Contains(name))
                {
                    // If it has already appeared before, this will display a message indicating so.
                    Console.WriteLine("{0} has already appeared in the list.", name);
                }
                else
                {
                    // If it has not appeared already this will add it to the hashset and display a message indicating it is unique.
                    uniqueNames.Add(name);
                    Console.WriteLine("{0} is a unique name.", name);
                }
            }
            Console.ReadLine();
        }
    }
}
