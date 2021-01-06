using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {

         int id;
         string name;
         double salary;

         Funcionario f = new Funcionario();

         List<Funcionario> lista = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i=0;i<N;i++) {
                Console.WriteLine("Employer #" + (i+1));

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id,name,salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            f = lista.Find(x => x.Id == id);

            if (f == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {

                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                salary = f.aumentoSalario(percentage);

                int pos = lista.FindIndex(x => x.Id == id);

                lista[pos].Salario = salary;
            }

            Console.WriteLine("\nUpdated list of employees: ");

            foreach (Funcionario item in lista) {
                Console.Write(item.Id + ", " + item.Name + ", " + item.Salario.ToString("F2",CultureInfo.InvariantCulture) + "\n");
            }


        }
    }
}
