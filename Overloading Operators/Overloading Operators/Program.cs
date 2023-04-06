using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This instantiates two Employee objects and assign values to their properties.
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

            // This compares the two Employee objects using the overloaded operators and display the results.
            Console.WriteLine($"employee1 == employee2 : {employee1 == employee2}");
            Console.WriteLine($"employee1 != employee2 : {employee1 != employee2}");

            Console.ReadKey();
        }
    }
}
