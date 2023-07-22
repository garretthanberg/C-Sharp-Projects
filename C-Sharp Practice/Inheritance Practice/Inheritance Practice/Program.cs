using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object with a first name of "Sample and a last name of "Student."
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student",
                Id = 1234
            };

            // This calls the superclass method sayName() on the Employee object.
            employee.sayName();

            Console.ReadLine();
        }
    }
}
