using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    // This defines an Employee class that inherits IQuittable and implements the Quit() method.
    public class Employee : IQuittable
    {
        public string Name { get; set; }
        public int Id { get; set; }

        // This implements the Quit() method from IQuittable.
        public void Quit()
        {
            Console.WriteLine($"Employee {Name} with ID {Id} has quit the company.");
        }
    }
}
