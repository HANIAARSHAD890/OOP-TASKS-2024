using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class AdminUI
    {
        public static void AdminMenu()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered (less than threshold)");
            Console.WriteLine("6. View Profile (Username, Password)");
            Console.WriteLine("7. Exit");
        }
        
    }
}
