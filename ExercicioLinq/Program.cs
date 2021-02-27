using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExercicioLinq.Entities;
using System.Collections.Generic;

namespace ExercicioLinq {
    class Program {
        static void Main(string[] args) {

            //Database utilized is in folder "Database" named as linq.txt            

            List<Employee> list = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] field = sr.ReadLine().Split(',');

                    list.Add(new Employee(field[0],field[1],double.Parse(field[2],CultureInfo.InvariantCulture)));
                }
            }

            Console.WriteLine("Email of people whose salary is more than " + salary.ToString("F2",CultureInfo.InvariantCulture) + ":");

            IEnumerable<string> result = list.Where(p => p.Salary > 2000.00).OrderBy(p => p.Email).Select(p => p.Email);

            foreach (string item in result) {
                Console.WriteLine(item);
            }

            double sumSalary = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).DefaultIfEmpty(0.0).Sum();

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumSalary.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
