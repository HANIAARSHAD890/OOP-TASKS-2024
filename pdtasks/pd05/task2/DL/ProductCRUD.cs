using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ProductCRUD
    {
       public static  List<Product>ListofProducts=new List<Product>();

        public static  void retrieve(Product p )
        {
           
                Console.WriteLine("\nProduct Details:");
                Console.WriteLine($"Name: {p.Name}");
                Console.WriteLine($"Category: {p.Category}");
                Console.WriteLine($"Price: {p.Price:F2}");
                Console.WriteLine($"Available Stock Quantity: {p.AvailableStock}");
                Console.WriteLine($"Minimum Stock Threshold: {p.MinStockThreshold}");
                Console.WriteLine($"Order Quantity Threshold: {p.OrderQuantity}");
            }
        public  static Product highestPriceRetrieval()
            {
            List<float> ListofPrice = new List<float>();
         
            for (int i = 0; i < ListofProducts.Count; i++)
            {
                ListofPrice.Add(ListofProducts[i].Price);
            }
            ListofPrice.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < ListofProducts.Count; i++)
            {
                if (ListofProducts[i].Price == ListofPrice[0])
                {
                    return ListofProducts[i];
                }
            }
            return null;
            
        }

    }
}

