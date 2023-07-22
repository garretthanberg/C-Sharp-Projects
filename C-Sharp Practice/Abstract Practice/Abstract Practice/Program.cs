using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates an Employee object with first name "Sample" and last name "Student."
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };

            // This calls the sayName method on the Employee object.
            employee.sayName();

            Console.ReadLine();
      
        }
    }
}
