using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    // This is a seperate class for the math operations.
    public class MathOperations
    {
        // This method multiplies the input by 2 and returns the result.
        public int Double(int input)
        {
            return input * 2;
        }

        // This method squares the input and returns the result.
        public int Square(int input)
        {
            return input * input;
        }

        // This method divides the input by 2 and returns the result.
        public int Divide(int input)
        {
            return input / 2;
        }
    }
}
