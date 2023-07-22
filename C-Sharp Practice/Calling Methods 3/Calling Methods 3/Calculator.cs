using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_3
{
    public class Calculator
    {
        public int mathOperation(int firstNumber, int secondNumber = 0)
        {
            // This will do a math operation and return an integer result.
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
