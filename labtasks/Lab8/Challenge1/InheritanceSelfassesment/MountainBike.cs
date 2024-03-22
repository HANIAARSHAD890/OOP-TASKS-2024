using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSelfassesment
{
    internal class MountainBike: Bicycle
    {
        private int seatHeight;
    public MountainBike(int seatHeight,int cadence,int speed,int gear): base(cadence,speed,gear)
        {
            this.seatHeight = seatHeight;
            this.cadence = cadence;
            this.speed = speed; 
            this.gear = gear;
        }
        public void SetSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
        public void GetAllInfo()
        {
            Console.WriteLine($"SeatHeight: {seatHeight}");
            Console.WriteLine($"Cadence: {cadence}");
            Console.WriteLine($"Gear: {gear}");
            Console.WriteLine($"Speed: {speed}");
        }
    }
}
