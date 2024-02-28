using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class MenuItemCRUD
    {
        public void AddMenuItem(CoffeShop c,MenuItem item)
        {
            c.ItemsInMenu.Add(item);
        }
        public string GetMenuItemName() { 
        }
    }
}
