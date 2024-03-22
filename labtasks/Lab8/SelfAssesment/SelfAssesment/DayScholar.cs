using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace SelfAssesment
{
    internal class DayScholar:Student
    {
        private string PickUpPoint;
        private int Busno;
        private int PickUpDistance;
        public DayScholar(string pickUpPoint, int busNo, int pickUpDistance, string name, string session, bool isDayScholar, float entrytestMarks,float hSMarks) : base(name, session, isDayScholar,entrytestMarks,  hSMarks)
        { 
            PickUpPoint=pickUpPoint; 
            Busno=busNo;
            PickUpDistance = pickUpDistance; 
            Name = name;
            Session = session;
            IsDayScholar=isDayScholar;
            EntrytestMarks=entrytestMarks;
            HSMarks = hSMarks;
        }
        public double GetBusFees()
        {
            double fee = PickUpDistance * 20;
            return fee; 
        }
        public void GetALLInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Session:{Session}");
            Console.WriteLine($"Busfees:{GetBusFees()}");
            Console.WriteLine($"BusNo{Busno}");
            Console.WriteLine($"PickupDistance:{PickUpDistance}");
            Console.WriteLine($"PicUpPoint:{PickUpPoint}");

        }
        public void SetName(string name )
        {
            Name = name ;
        }
        public void Setbusno(int busno)
        {
            Busno= busno;
        }
    }
}
