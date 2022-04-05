using System;
using System.Collections.Generic;
using System.Text;

namespace _05042022.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }
    }
}
