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

        // This overloads the "==" operator to compare two Employee objects by their Id property.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both objects are null, or if thet are the same instance, this returns true.
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // If one object is null, or if they have different Id values, this returns false.
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null) || employee1.Id != employee2.Id)
            {
                return false;
            }

            // Otherwise, the objects are equal.
            return true;
        }

        // This overloads the "!=" operator to negate the result of the "==" operator.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
