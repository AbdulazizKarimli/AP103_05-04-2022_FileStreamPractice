using Homework.Models;
using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "test1 employee",
                Salary = 120
            };
            Employee employee2 = new Employee()
            {
                Name = "test2 employee",
                Salary = 125
            };

            Department department = new Department();
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);

            //foreach (Employee item in department)
            //{
            //    item.ShowInfo();
            //}

            department[0].ShowInfo();
            department[0].Name = "Test12 employee";
            department[0].ShowInfo();
        }
    }
}
