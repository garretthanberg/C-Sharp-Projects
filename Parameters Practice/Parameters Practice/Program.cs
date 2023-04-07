using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type string as its generic parameter.
            Employee<string> employeeString = new Employee<string>();
            // Assign a list of strings to the Things property.
            employeeString.Things = new List<string>() { "thing1", "thing2", "thing3" };

            // Instantiate an Employee object with type int as its generic parameter.
            Employee<int> employeeInt = new Employee<int>();
            // Assign a list of integers to the Things property.
            employeeInt.Things = new List<int>() { 1, 2, 3 };

            // Loop through all of the strings in employeeString.Things and print them to the console.
            foreach (var item in employeeString.Things)
            {
                Console.WriteLine(item);
            }

            // Loop through all of the integers in employeeInt.Things and print them to the console.
            foreach (var item in employeeInt.Things)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
