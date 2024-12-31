using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    class Employee
    {
        private static int nextId = 101;
        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Id = nextId++;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Salary}";
        }
    }

    class Question2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Employee Name ");
            string name1 = Console.ReadLine();

            Console.Write("Enter First Employee salary ");
            double salary1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Employee Name ");
            string name2 = Console.ReadLine();

            Console.Write("Enter Second Employee salary ");
            double salary2 = double.Parse(Console.ReadLine());

            Employee emp1 = new Employee(name1, salary1);
            Employee emp2 = new Employee(name2, salary2);

            Console.WriteLine("Employee Details are: ");
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }

}
