using _05042022.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace _05042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl + k + d => prettify
            Directory.CreateDirectory(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_05-04-2022_FileStreamPractice\FileStream\05042022\Files");
            if (!File.Exists(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_05-04-2022_FileStreamPractice\FileStream\05042022\Files\database.json"))
            {
                File.Create(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_05-04-2022_FileStreamPractice\FileStream\05042022\Files\database.json");
            }

            Employee employee1 = new Employee()
            {
                Id = 1,
                Name = "test1 employee",
                Salary = 123
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                Name = "test2 employee",
                Salary = 234
            };

            Department department = new Department()
            {
                Id = 1,
                Name = "test department"
            };

            department.Employees.Add(employee1);
            department.Employees.Add(employee2);

            string jsonStr = JsonConvert.SerializeObject(department);
            //Console.WriteLine(jsonStr);
            using (StreamWriter sw = new StreamWriter(@"D:\Programming\CodeAcademy\Work\AzTU\AP103\C#\ClassWorks\AP103_05-04-2022_FileStreamPractice\FileStream\05042022\Files\database.json"))
            {
                sw.Write(jsonStr);
            }
        }
    }
}
