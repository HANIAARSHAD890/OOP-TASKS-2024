using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem("Cheeseburger", "Main Course", 9.99f);
            MenuItem item2 = new MenuItem("Caesar Salad", "Appetizer", 7.49f);
            MenuItem item3 = new MenuItem("Chocolate Cake", "Dessert", 5.99f);
            MenuItem item4 = new MenuItem("Iced Tea", "Beverage", 2.49f);
            MenuItem item5 = new MenuItem("French Fries", "Side Dish", 3.99f);
            List<MenuItem> list = new List<MenuItem>();
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            list.Add(item5);
            CoffeShop c1 = new CoffeShop("Coffee A");
            CoffeShop c2 = new CoffeShop("Coffee B");
            CoffeShop c3 = new CoffeShop("Coffee C");
            CoffeShop c4 = new CoffeShop("Coffee D");
            CoffeShop c5 = new CoffeShop("Coffee E");



        }
    }
}
