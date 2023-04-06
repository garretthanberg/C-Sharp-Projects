using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Practice
{
    // This defines the Employee class that inherits from Person.
    public class Employee : Person
    {
        // This implements the sayName method for Employee.
        public override void sayName()
        {
            Console.WriteLine($"My name is {firstName} {lastName}.");
        }
    }
}
