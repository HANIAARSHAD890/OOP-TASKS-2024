using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3{
    internal class CoffeeShopUI
    {
        public static CoffeShop InputForcoffeeShop () {
            Console.WriteLine("Write name of the shop");
            string name= Console.ReadLine();
            CoffeShop c = new CoffeShop(name);
            return c;
        }

    }
}
