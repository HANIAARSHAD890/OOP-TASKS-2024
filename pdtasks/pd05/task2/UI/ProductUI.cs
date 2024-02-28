using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ProductUI
    {
        public static Product inputforProduct()
        {
            Console.WriteLine("Enter product name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter product category: ");
            string Category = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            float Price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter available stock quantity: ");
            int AvailableStock = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter minimum stock threshold: ");
            int MinStockThreshold = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter quantity after which the owner wants to order the product: ");
            int OrderQuantity = int.Parse(Console.ReadLine());
            Product p = new Product(Name, Category, Price, AvailableStock, MinStockThreshold, OrderQuantity);
            return p;
        }
        public static void OrderProducts(Product p)
        {
            if (p != null)
            {
                Console.WriteLine($"this {p.Name} has to be ordered as it is in number {p.OrderQuantity} in the stock");
            }

        }
    }
}