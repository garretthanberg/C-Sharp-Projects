using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_2
{
    // This defines a class for math operations.
    public class Calculator
    {
        // This method takes an integer, adds 10 to it, and returns the result.
        public int mathOperation(int input)
        {
            return input + 10;
        }

        // This method takes a decimal, multiplies it by 2, and returns the result.
        public int mathOperation(decimal input)
        {
            return (int)(input * 2);
        }

        // This method takes a string, tries to parse it as an integer, adds 5 to it, and returns the result.
        public int mathOperation(string input)
        {
            int parsedInput;
            if (int.TryParse(input, out parsedInput))
            {
                return parsedInput + 5;
            }
            else
            {
                Console.WriteLine("Input could not be parsed as an integer.");
                return 0;
            }
        }
    }
}
