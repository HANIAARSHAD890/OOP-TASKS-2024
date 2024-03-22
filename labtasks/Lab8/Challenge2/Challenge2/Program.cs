using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circle parent = new Circle();
            Cylinder child= new Cylinder();
           Console.WriteLine( parent.ToString());
            Console.WriteLine("write color");
            string color = Console.ReadLine();
            Console.WriteLine("write radius");
            double radius = double.Parse(Console.ReadLine());
            child.Setcolor(color);
            child.Setradius(radius);
            Console.WriteLine(child.ToString());
            Console.ReadKey();
            ///////////////////////////
        }
    }
}
