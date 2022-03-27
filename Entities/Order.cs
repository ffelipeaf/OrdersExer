using System;
using System.Collections.Generic;
using Exerc.Entities.Enums;
using System.Text;


namespace Exerc.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();



        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        


       public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment: {Moment.ToString("G")}");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine($"Order Items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
