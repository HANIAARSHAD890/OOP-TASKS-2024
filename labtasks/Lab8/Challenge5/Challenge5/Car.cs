using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Car
    {
        protected string Color;
        protected string Model;
        protected double Price;
        public Car(string color, string model, double price)
        {
            Color = color;  
            Model = model;
            Price = price;
        }
        public string GetModel()
        {
          return Model;
        }
        public void SetModel(string model)
        {
            Model = model;
        }
        public string ToString()
        {
            return $"Color: {Color},Model: {Model},Price: {Price}";
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
