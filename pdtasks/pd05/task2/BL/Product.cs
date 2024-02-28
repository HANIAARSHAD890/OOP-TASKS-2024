using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Product
    {
        public string Name;
        public string Category;
        public float Price;
        public int AvailableStock;
        public int MinStockThreshold;
        public int OrderQuantity;

        public Product(string name,string category ,float price ,int availableStock,int minStock,int orderQuantity)

        {
            Name = name;
            Category = category;    
            Price = price;
            AvailableStock = availableStock;
            MinStockThreshold = minStock;
            OrderQuantity = orderQuantity;

        }
        public static  float taxcalculator(Product p )
        {
            float tax = 0;
            if (p.Category == "fruit")
            {
                tax = 5.00F / p.Price * p.Price;
            }
            else if (p.Category == "grocery")
            {
                tax = 10.00F / p.Price * p.Price;
            }
            else
            {
                tax = 15.00F / p.Price * p.Price;

            }
            return tax;
        }
        public static Product RetrieveProductsHaveMinthreshold(Product p)
        {
            if (p.MinStockThreshold > p.OrderQuantity)
            {
                return p;
            }
            return null;
        }
    }
}
