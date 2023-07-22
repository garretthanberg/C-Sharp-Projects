using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Practice
{
    internal class Person
    {
        public string name;
        public string location;
        public string postcode;

        // This chains constructors together.
        public Person() : this("Unknown")
        {
        }

        public Person(string name) : this(name, "Portland, OR", "97205")
        {
        }

        public Person(string name, string location, string postcode)
        {
            this.name = name;
            this.location = location;
            this.postcode = postcode;
        }
    }
}
