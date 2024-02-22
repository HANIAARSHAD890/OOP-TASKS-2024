using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double a = 10;
            double b = 10;
            Console.WriteLine("BASIC CALCULATOR");
            Console.WriteLine("Write the first value: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the second value: ");
            b = double.Parse(Console.ReadLine());
            calculator cs = new calculator(a, b);
            Console.WriteLine("ADD");
            Console.WriteLine(cs.add());
            Console.WriteLine("subtract");
            Console.WriteLine(cs.subtract());
            Console.WriteLine("multiply");
            Console.WriteLine(cs.multiply());
            Console.WriteLine("divide");

            if (cs.divide() == 0)
            {
                errorbox();
            }
            else
            {
                Console.WriteLine(cs.divide());
            }
            Console.ReadKey();
        }
        static void errorbox()
        {
            Console.WriteLine("Div error");
        }


    }
}