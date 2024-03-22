using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Cylinder:Circle
    {
        private double Height;
        public Cylinder() : base()
        {
            
        }
        public Cylinder(int radius,string color):base(radius,color)
        {
            Radius = radius;
        }
        public Cylinder(int radius,int height,string color):base(radius,color)
        {
            Radius = radius;
            Height = height;
        }
        public double GetHeight()
        
        {
            return Height;
        }
        public double Getvolume()

        {
            return Height*Radius*Radius*3.14;
        }
        public string ToStringChild()
        {
            return $"Color: {Color},radius: {Radius},Height: {Height},volume: {Getvolume()} ";
        }
    }
}
