using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enum;

namespace ExercicioEnum {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        

        public Order() {
            
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            Items.Add(item);
        }

        public void removeItem(OrderItem item) {
            Items.Remove(item);
        }

        public double total() {

            double sum = 0;

            foreach(OrderItem obj in Items) {
                sum += obj.subTotal();
            }

            return sum;
        }

        public override string ToString() {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment);
            sb.AppendLine("Order status: " + Status);
            sb.Append("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.Append($" - {Client.Email}");
            sb.AppendLine("Order items: ");

            foreach (OrderItem obj in Items) {
                sb.Append($"{obj.Product.Name}, $" + obj.Product.Price.ToString("F2",CultureInfo.InvariantCulture));
                sb.AppendLine($", Quantity: {obj.Quantity}, Subtotal: $" + obj.subTotal().ToString("F2",CultureInfo.InvariantCulture));
            }

            sb.AppendLine($"Total price: $" + total().ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();
        }


    }
}
