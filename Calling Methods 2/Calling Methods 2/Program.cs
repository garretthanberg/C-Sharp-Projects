using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This instantiates the Calculator class.
            Calculator calculator = new Calculator();

            // This calls the first method with an integer input and displays the result.
            int intResult = calculator.mathOperation(5);
            Console.WriteLine("Integer result: " + intResult);

            // This calls the second method with a decimal input and displays the result.
            int decimalResult = calculator.mathOperation(3.14m);
            Console.WriteLine("Decimal result: " + decimalResult);

            // This calls the third method with a string input and displays the result.
            int stringResult = calculator.mathOperation("10");
            Console.WriteLine("String result: " + stringResult);

            // This waits for the user to press a key before closing the console.
            Console.ReadLine();
        }
    }
}
