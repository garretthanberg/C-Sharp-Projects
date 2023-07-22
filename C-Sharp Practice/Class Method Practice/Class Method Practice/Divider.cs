using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Practice
{
    public class Divider
    {
        // This creates a void method that outputs an integer.
        public void divideBy2(int num)
        {
            // This divides the data passed to it by 2.
            int result = num / 2;
            Console.WriteLine($"The result of dividing {num} by 2 is {result}");
        }

        // THis creates a method with output parameters.
        public int multiplyBy2(int num, out int product)
        {
            product = num * 2;
            return product;
        }

        // This overloads the method.
        public int multiplyBy2(int num)
        {
            return num * 2;
        }
    }
}
