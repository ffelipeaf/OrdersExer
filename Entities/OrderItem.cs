using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Exerc.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        { 
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double Subtotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, Sutbtotal: {Subtotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
    
}
