using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TwoConstructors1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ship> shipList = new List<ship>();



            //////  variables related to input function
            float latdeg = 0;
            float longdeg = 0;
            float latmin = 0;
            float longmin = 0;
            char longdirection = 'n';
            char latdirection = 'n';
            int index = 0;

            int shipno = 0;
            Console.WriteLine("ADDING SHIPS");
            shipList.Add(Addship());
            shipList.Add(Addship());
            Console.WriteLine("VIEW SHIP POSITION");
            for (int x = 0; x < shipList.Count; x++)
            {
                Console.WriteLine(shipList[x].longitude.DisplayAngle());
                Console.WriteLine(shipList[x].latitude.DisplayAngle());
            }
          
            Console.WriteLine("VIEW SERIAL NUMBER");
            for (int x = 0; x < shipList.Count; x++)
            {
                shipList[x]. printserialNo();
            }
          
            Console.WriteLine("CHANGE SHIP POSITION");
            changeangle(shipList, ref shipno, ref latdeg, ref latmin, ref latdirection, ref longdeg, ref longmin, ref longdirection, ref index);
            Console.WriteLine("VIEW SHIP POSITION");
            for (int x = 0; x < shipList.Count; x++)
            {
                Console.WriteLine(shipList[x].longitude.DisplayAngle());
                Console.WriteLine(shipList[x].latitude.DisplayAngle());
            }



        }
        static void takeinput(ref int shipno, ref float latdeg, ref float latmin, ref char latdirection, ref float longdeg, ref float longmin, ref char longdirection)
        {
            Console.WriteLine("Enter ship no:");
            shipno = int.Parse(Console.ReadLine());
            Console.WriteLine("FOR LATITUDE");
            Console.WriteLine("write the deg");
            latdeg = float.Parse(Console.ReadLine());
            Console.WriteLine("Write min");
            latmin = float.Parse(Console.ReadLine());
            Console.WriteLine("Write direction");
            latdirection = char.Parse(Console.ReadLine());

            Console.WriteLine("FOR LONGITUDE");
            Console.WriteLine("write the deg");
            longdeg = float.Parse(Console.ReadLine());
            Console.WriteLine("Write min");
            longmin = float.Parse(Console.ReadLine());
            Console.WriteLine("Write direction");
            longdirection = char.Parse(Console.ReadLine());
        }
        static void changeangle(List<ship> shipList, ref int shipno, ref float latdeg, ref float latmin, ref char latdirection, ref float longdeg, ref float longmin, ref char longdirection,ref int index)
        {

            Console.WriteLine("Enter the ship no for which u want to change the location");
            int serialno = int.Parse(Console.ReadLine());
            index = shipList.FindIndex(item => item.shipno == serialno);
            takeinput(ref shipno, ref latdeg, ref latmin, ref latdirection, ref longdeg, ref longmin, ref longdirection);
          shipList[index].latitude.ChangeAngle(ref latdeg, ref latmin, ref latdirection);
          shipList[index].longitude.ChangeAngle(ref longdeg, ref longmin, ref longdirection);
           
        }
        static ship Addship()
        {
            Console.WriteLine(" Write ship no ");
            int shipno = int.Parse(Console.ReadLine());
            Console.WriteLine("FOR LATITUDE");
            Console.WriteLine("write the deg");
            float latdeg = float.Parse(Console.ReadLine());
            Console.WriteLine("Write min");
            float latmin = float.Parse(Console.ReadLine());
            Console.WriteLine("Write direction");
            char latdirection = char.Parse(Console.ReadLine());
            Console.WriteLine("FOR LONGITUDE");
            Console.WriteLine("write the deg");
            float longdeg = float.Parse(Console.ReadLine());
            Console.WriteLine("Write min");
            float longmin = float.Parse(Console.ReadLine());
            Console.WriteLine("Write direction");
            char longdirection = char.Parse(Console.ReadLine());
            ship no1 = new ship(shipno, latdeg, latmin, latdirection, longdeg, longmin, longdirection);
            return no1;
        }

    }
}
