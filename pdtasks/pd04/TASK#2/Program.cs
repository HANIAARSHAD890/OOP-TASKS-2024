using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stats fireball = new stats("fireball", 23, 1.2F, 5, 15, "a firey magical attack");
            stats superbeam = new stats("superbeam", 200, 50, 50, 75, "an overpowered attack, pls nerf");
            player alice = new player( 110, 50, 10,"Alice");
            player bob = new player(100, 60, 20, "Bob");
            Console.WriteLine("UPDATE HEALTH");
            Console.WriteLine(alice.updatehealth(float.Parse(Console.ReadLine())));
            Console.WriteLine("UPDATE ARMOUR");
            Console.WriteLine(alice.updatearmour(float.Parse(Console.ReadLine())));
            Console.WriteLine("UPDATE ENERGY");
            Console.WriteLine(alice.updateenergy(float.Parse(Console.ReadLine())));
            Console.WriteLine("UPDATE NAME");
            Console.WriteLine(alice.updatename(Console.ReadLine()));
            Console.WriteLine("LEARNING A SKILL");
            Console.WriteLine(alice.learnskill(fireball));
            Console.WriteLine("CALLING SKILL");
            Console.WriteLine(alice.attack(bob));
            
        }
    }
}
