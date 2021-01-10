using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioPolimorfismo.Entities;

namespace ExercicioPolimorfismo {
    class Program {
        static void Main(string[] args) {

            int N;
            List<Product> list = new List<Product>();
            string name;
            double price,ctFee;
            DateTime mDate;

            Console.Write("Enter the number of products: ");
            N = int.Parse(Console.ReadLine());

            for (int i=1;i<=N;i++) {
                Console.Write($"Product #{N} data:");

                char x;
                Console.Write("\nCommon, used or imported (c/u/i)?");
                x = char.Parse(Console.ReadLine());

                if (x == 'c') {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Product p = new Product(name,price);
                    list.Add(p);
                }

                else if (x == 'u') {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    mDate = DateTime.Parse(Console.ReadLine());

                    UsedProduct up = new UsedProduct(name,price,mDate);
                    list.Add(up);
                }

                else if(x == 'i') {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Customs fee: ");
                    ctFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    ImportedProduct ip = new ImportedProduct(name,price,ctFee);
                    list.Add(ip);
                }

            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product obj in list) {
                Console.WriteLine(obj.priceTag());
            }
        }
    }
}
