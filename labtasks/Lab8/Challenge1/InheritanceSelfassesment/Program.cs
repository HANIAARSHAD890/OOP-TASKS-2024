using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSelfassesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////creating MountainBike Object////////
            MountainBike b = new MountainBike(6, 5, 89, 8);
            Console.WriteLine("Enter cadence");
            int cadence = int.Parse(Console.ReadLine());
            b.SetCadence(cadence);
           b.GetAllInfo();
            Console.ReadKey();
            Console.WriteLine("SetGear");
            int gear = int.Parse(Console.ReadLine());
            b.SetGear(gear);
            b.GetAllInfo();
            Console.ReadKey();
            Console.WriteLine("ApplyBrake");
            int decrement = int.Parse(Console.ReadLine());
            b.ApplyBrake(decrement); 
            b.GetAllInfo();
            Console.ReadKey();
            Console.WriteLine("SpeedUp");
            int increment = int.Parse(Console.ReadLine());
            b.SpeedUp(increment);
            b.GetAllInfo();
            Console.ReadKey();
            /////bike attributes /////
            Console.WriteLine("Enter cadence");
            int ParentCadence = int.Parse(Console.ReadLine());
            b.SetCadence(ParentCadence);
            Console.WriteLine("Enter gear");
            int ParentGear = int.Parse(Console.ReadLine());
            b.SetGear(ParentGear);
            Console.WriteLine("Showing Parent Details");
            b.GetAllInfoOfParent();
            Console.ReadKey();  

        }
    }
}
