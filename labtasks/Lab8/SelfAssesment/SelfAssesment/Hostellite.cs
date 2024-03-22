using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace SelfAssesment
{
    internal class Hostellite : Student
    {
        private bool IsFridgeAvailable;
        private bool IsNetAvailable;
        private int RoomNo;
        public Hostellite(string name, string session, bool isDayScholar, bool isFridgeAvailable, float entrytestMarks, float hSMarks, bool isNetAvailable, int roomNo) : base(name, session, isDayScholar, entrytestMarks, hSMarks)
        {
            IsFridgeAvailable = isFridgeAvailable;
            IsNetAvailable = isNetAvailable;
            RoomNo = roomNo;
        }
        public double GetHostelFees()
        {
            double fee = 0;
            if ((IsFridgeAvailable) && (IsNetAvailable))
            {
                fee = 400;
            }
            if ((IsFridgeAvailable) && (!IsNetAvailable))
            {
                fee = 200;
            }
            return fee;
        }
        public void GetALLInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Session:{Session}");
            Console.WriteLine($"hostelfees:{GetHostelFees()}");
            Console.WriteLine($"RoomNo{RoomNo}");
            Console.WriteLine($"IsFridgeAvailable:{IsFridgeAvailable}");
            Console.WriteLine($"IsNetavailable:{IsNetAvailable}");

        }
        public void Setname(string name)
        {
            Name = name;
        }
        public void SetroomNo(int roomNo)
        {
            RoomNo = roomNo;
        }
    }
}
