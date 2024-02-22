using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoConstructors1
{
    internal class ship
    {
        public int shipno;
        public angle latitude;
        public angle longitude;
     
        public ship(int shipno, float latdeg, float latmin, char latdirection, float longdeg, float longmin, char longdirection)
        {
            this.shipno = shipno;
            this.latitude = new angle(latdeg, latmin, latdirection);
            this.longitude = new angle(longdeg, longmin, longdirection);

        }
        public void printposition(ship objs)
        {
            Console.WriteLine(objs.latitude.DisplayAngle());
            Console.WriteLine(objs.longitude.DisplayAngle());  
          
        }
        public void printserialNo()
        {
            Console.WriteLine(shipno);

        }
    }
}
