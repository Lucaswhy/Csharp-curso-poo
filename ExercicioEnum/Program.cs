using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enum;
using System;
using System.Globalization;
using System.Text;

namespace ExercicioEnum {
    class Program {
        static void Main(string[] args) {

            string name,email;
            int N;
            DateTime date;
            OrderStatus status;

            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now,status,client);

            Console.WriteLine("How many items to this order? ");
            N = int.Parse(Console.ReadLine());

            for (int i=1;i<=N;i++) {

                string pName = "";
                double price = 0;
                int quantity = 0;

                Console.WriteLine($"Enter #{N} item data: ");

                Console.Write("Product Name: ");
                pName = Console.ReadLine();

                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                Product product = new Product(pName,price);
                OrderItem item = new OrderItem(quantity,price,product);

                order.addItem(item);

            }

            Console.WriteLine(order.ToString());



        }
    }
}
