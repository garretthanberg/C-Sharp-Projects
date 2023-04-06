using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // This creats an object of type IQuittable using polymorphism.
            IQuittable employee = new Employee() { Name = "John Doe", Id = 123 };

            // This calls the Quit() method on the IQuittable object.
            employee.Quit();

            Console.ReadLine();
        }
    }
}
