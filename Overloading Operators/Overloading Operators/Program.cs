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

            // This compares the two Employee ID's using the overloaded operators and displays the results.
            Console.WriteLine($"Employee 1\'s ID == Employee 2\'s ID : {employee1.Id == employee2.Id}");
            Console.WriteLine($"Employee 1\'s ID != Employee 2\'s ID : {employee1.Id != employee2.Id}");

            Console.ReadKey();
        }
    }
}
