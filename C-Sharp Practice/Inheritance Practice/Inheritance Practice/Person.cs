using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice
{
    // This creates a class callled Person and give it two properties, each of data type string.
    public class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }

        // This gives the class a void method called sayName() that takes no parameters and simply writes the person's full name to the console.
        public void sayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
