using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Routine r1 = new Routine("6:00am");
            Routine r2 = new Routine("7:00am");
            Routine r3 = new Routine("8:00am");
            Routine r4 = new Routine("9:00am");
            Routine r5 = new Routine("10:00am");

            Routine.ListOfRoutines.Add(r1);
            Routine.ListOfRoutines.Add(r2);
            Routine.ListOfRoutines.Add(r3);
            Routine.ListOfRoutines.Add(r4);
            Routine.ListOfRoutines.Add(r5);
            Console.WriteLine("Get Routine TImings ");
            {
                Console.WriteLine(r1.Gettimings());
            }
        }
    }
}
