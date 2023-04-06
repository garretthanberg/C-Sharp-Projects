using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Practice
{
    // This defines the abstract Person class.
    public abstract class Person
    {
        // These are the properties for first and last name.
        public string firstName {  get; set; }
        public string lastName { get; set; }

        // This is the abstract method that subclasses must implement.
        public abstract void sayName();
    }
}
