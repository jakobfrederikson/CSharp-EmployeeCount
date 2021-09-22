using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCount
{
    public class Employee
    {
        // modifiable variables
        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        private int _age;
        public int Age 
        {
            get { return _age; }
            set { _age = value; } 
        }

        private double _salary;
        public double Salary 
        {
            get { return _salary; }
            set { _salary = value; } 
        }

        // static variables
        private static int _employee_count = 0;

        // THIS NEEDS TO BE A STATIC METHOD!!!!
        public static int EmployeeCount
        {
            get { return _employee_count; }
        }

        public Employee()
        {
            _employee_count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("EMPLOYEE DATA SYSTEM");
                Console.WriteLine("--------------------");
                Console.WriteLine("How many employee's are there? ");
                int emp_count = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nTAKING INPUT FOR " + emp_count + " EMPLOYEES");
                Console.WriteLine("----------------------------");

                for (int i = 0; i < emp_count; i++)
                {
                    Employee e = new Employee();
               
                    Console.WriteLine("Enter employee name: ");
                    e.Name = Console.ReadLine();

                    Console.WriteLine("Enter employee age: ");
                    e.Age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter employee salary: ");
                    e.Salary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(e.Name + " " + e.Age + " " + e.Salary + "\n");
                }

                // We can access EmployeeCount because we made it a static method
                Console.WriteLine("Employee count is: " + Employee.EmployeeCount + "\n");
                break;
            }
        }
    }
}