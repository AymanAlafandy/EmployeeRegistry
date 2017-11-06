using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegistry
{
    class Program
    {
        static void Main(string[] args)
        {            
            var registry = new Registry();
            var added = true;
            do {
                added = AddEmployee(registry);
            } while (added);

            Console.WriteLine("====================");
            //registry.List();
            Console.WriteLine(registry);

        }

        private static bool AddEmployee(Registry registry)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) return false;

            Console.Write("Salary: ");
            var salaryString = Console.ReadLine();

            int salary = 0;
            if (!int.TryParse(salaryString, out salary)) {
                Console.WriteLine("Salary couldn't be parsed.");
            }
            var employee = new Employee(name);
            employee.Salary = salary;
            registry.Add(employee);

            return true;
        }
    }
}
