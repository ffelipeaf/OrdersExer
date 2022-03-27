using System;
using Exerc.Entities;
using Exerc.Entities.Enums;

namespace Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("BirthDate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client();
            client.Name = clientName;
            client.Email = clientEmail;
            client.BirthDate = birthDate;

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items in this order? ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                
                Console.WriteLine($"Enter #{i+1} item");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }

            Console.WriteLine("Order Summary:");
            Console.Write(order);

        }
    }
}