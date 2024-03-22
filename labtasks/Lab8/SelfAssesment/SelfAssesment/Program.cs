using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace SelfAssesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///// object creation
            DayScholar d = new DayScholar("ShalamarGarden", 8, 78, "Hania", "23", true, 232, 1050);
            Hostellite h = new Hostellite("Arwa", "23", true, true, 400, 1100, true, 214);
            //////Info For Hostellite
                   h.GetALLInfo();
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            h.Setname(name);   
            Console.WriteLine("Enter Roomno");
            int roomno = int.Parse(Console.ReadLine());
            h.SetroomNo(roomno);
            h.GetALLInfo();
            /////info for the dayScholar
            d.GetALLInfo();
            Console.WriteLine("Enter name");
            string named = Console.ReadLine();
            d.SetName(named);
            Console.WriteLine("Enter Busno");
            int busno = int.Parse(Console.ReadLine());
            d.Setbusno(busno);
            d.GetALLInfo();
        }
    }
}
