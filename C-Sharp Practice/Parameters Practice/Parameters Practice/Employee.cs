using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Practice
{
    // This defines a generic Employee class with a type parameter T.
    public class Employee<T>
    {
        // This adds a property called "things" with the data type of List<T>, matching the type parameter of the class.
        public List<T> Things { get; set; }

        // Constructor to initialize the list of things.
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
