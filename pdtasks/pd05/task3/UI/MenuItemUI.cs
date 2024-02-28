using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class MenuItemUI
    {
        public static MenuItem GetInput()
        {
            Console.WriteLine("Enter the name of the menu item:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the type of the menu item:");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the price of the menu item:");
            float price=float.Parse(Console.ReadLine());
            MenuItem item = new MenuItem(name , type, price);
            return item;
        }
       
    }
}
