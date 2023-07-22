using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Practice
{
    // This defines a struct called Number with a decimal property called "Amount."
    public struct Number
    {
        public decimal Amount;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // This creates a new instance of the Number struct.
            Number myNumber = new Number();

            // This sets the amount property to a decimal value of 100.50.
            myNumber.Amount = 100.50M;

            // This prints the amount to the console.
            Console.WriteLine("The amount is: " + myNumber.Amount);

            Console.ReadLine();
        }
        
    }
}
