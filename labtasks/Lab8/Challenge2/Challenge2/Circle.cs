using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Circle
    {
        protected string Color= "red";
        protected double Radius=1.0;
        public Circle()
        { 

        }
        public Circle(string color)
        {
            Color = color;
        }
        public Circle(double radius,string color)
        {
            Color=color;
            Radius = radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public double GetRadius()
         {
            return Radius;
         }
        public void Setcolor(string color)
        {
            Color = color;
        }
        public void Setradius(double radius)
        {
            Radius = radius;
        }
        public double AreaCal()
        {
            return 3.14 * Radius * Radius;
        }
        public string ToString()
        {
            return $"Color: {Color},radius: {Radius},Area: {AreaCal()} ";
        }
    }
}
