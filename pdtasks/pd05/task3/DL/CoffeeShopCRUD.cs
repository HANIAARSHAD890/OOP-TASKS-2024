using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class CoffeeShopCRUD
    {

      public static List< CoffeShop>ListOfCofeeShops= new List< CoffeShop>();
        public static void AddCoffeShop(CoffeShop c )
        {
            ListOfCofeeShops.Add(c);
        }

    
    }
}
