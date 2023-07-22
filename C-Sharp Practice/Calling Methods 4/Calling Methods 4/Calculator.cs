using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_4
{
    public class Calculator
    {
        // This is a void method that takes two integers and performs a math operation on the first integer.
        // This also displays the second integer in the console.
        public void mathOperation(int x, int y)
        {
            int result = x * 2 + 10;
            Console.WriteLine($"The second integer is: {y}");
        }
    }
}
