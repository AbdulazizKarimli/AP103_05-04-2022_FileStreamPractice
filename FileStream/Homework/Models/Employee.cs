using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Employee
    {
        private static int _id; 

        public int Id { get; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Salary: {Salary}");
        }
    }
}
