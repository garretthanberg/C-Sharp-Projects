using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); // This instantiates the Calculator class.

            // This calls the method with two arguments.
            calculator.mathOperation(5, 7);

            // This calls the method with named parameters.
            calculator.mathOperation(x: 10, y: 20);

            Console.ReadLine();
        }
    }
}
