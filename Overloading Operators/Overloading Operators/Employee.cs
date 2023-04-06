using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    // This creates an Employee class with ID, FirstName, and LastName properties.
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                return false;
            }

            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
