using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          Audi a = new Audi("red", "2021", 3400000, 70, "XYX", 50);
          Gli g = new Gli("blue", "2023", 6700000, 50, "UIX", 40);
            Console.WriteLine(a.ToString());
            Console.WriteLine("For Car Audi");
            Console.WriteLine("How much distance you have travelled");
            double distance = double.Parse(Console.ReadLine());
            a.FuelConsumed(distance);
          
            Console.WriteLine(a.ToString());
          
            Console.WriteLine("For Car Gli");
            Console.WriteLine(g.ToString());
            Console.WriteLine("How much fuel you wanted to fulfill");
            double FuelFulfilled=double.Parse(Console.ReadLine());
            g.FuelFilling(FuelFulfilled);
            Console.WriteLine("Change Color of the Gli Car");
            string color = Console.ReadLine();
            g.SetColor(color);
            Console.WriteLine(g.ToString());
            Console.ReadKey();
        }
    }
}
