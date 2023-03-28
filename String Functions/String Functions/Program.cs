using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This concatenates three strings together.
            string string1 = "Hello";
            string string2 = " ";
            string string3 = "World";
            string concatenatedString = string1 + string2 + string3;
            Console.WriteLine(concatenatedString);
            Console.ReadLine();

            // This converts a string to uppercase.
            string lowercaseString = "this is a lowercase string.";
            string uppercaseString = lowercaseString.ToUpper();
            Console.WriteLine(uppercaseString);
            Console.ReadLine();

            // This creates a StringBuilder and builds a paragraph of text, oone sentence at a time.
            StringBuilder str = new StringBuilder();
            str.Append("This is the first sentence. ");
            str.Append("This is the second sentence. ");
            str.Append("This is the third sentence. ");
            string paragraph = str.ToString();
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
