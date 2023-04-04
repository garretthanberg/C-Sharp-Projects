using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice
{
    // This creates another class called Employee and has it inherit from the Person class.
    public class Employee : Person
    {
        // This gives the Employee class a property called Id of data type int.
        public int Id { get; set; }
    }
}
