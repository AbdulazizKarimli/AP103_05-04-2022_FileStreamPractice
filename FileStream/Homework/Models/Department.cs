using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    internal class Department : IEnumerable
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        private List<Employee> _employees;

        public Department()
        {
            _id++;
            Id = _id;
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var employee in _employees)
            {
                yield return employee;
            }
        }

        public Employee this[int index]
        {
            get => _employees[index];
            set => _employees[index] = value;
        }
    }
}
