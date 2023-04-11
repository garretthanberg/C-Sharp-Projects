using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This creates a list of 10 employees.
            var employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Smith" },
                new Employee { Id = 6, FirstName = "Sue", LastName = "Johnson" },
                new Employee { Id = 7, FirstName = "Amy", LastName = "Brown" },
                new Employee { Id = 8, FirstName = "Tom", LastName = "Green" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 10, FirstName = "Lisa", LastName = "Jones" }
            };

            //This creates a new list of all employees with the first name "Joe" using a foreach loop.
            var joes = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // This creates a new list of all employees with the first name "Joe" using a lambda expression.
            var joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // This creates a new list of all employees with an Id number greater than 5 using a lambda expression.
            var idGreater5 = employees.Where(e => e.Id > 5).ToList();
        }
    }
}
