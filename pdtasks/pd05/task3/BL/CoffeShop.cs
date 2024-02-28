using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class CoffeShop
    {
        public string Name;

        public List<MenuItem> ItemsInMenu;
        public List<string> Orders;

        public CoffeShop(string name)
        {
            Name = name;
            ItemsInMenu = new List<MenuItem>();
            Orders = new List<string>();
        }


    }
}
