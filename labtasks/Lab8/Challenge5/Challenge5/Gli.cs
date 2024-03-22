using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Gli: Car
    {


        private double FuelCapacity=80;
        private string EngineType;
        private double Fuel;
        public Gli(string color, string model, double price, double fuelCapacity, string engineType, double fuel) : base(color, model, price)
        {
            Color = color;
            Model = model;
            Price = price;
            FuelCapacity = fuelCapacity;
            Fuel = fuel;
            EngineType = engineType;


        }
        public void FuelConsumed(double distance)
        {
            double consumed = distance / 0.3;
            Fuel = Fuel - consumed;

        }
        public string FuelFilling(double fuel)
        {
            if (Fuel + fuel < FuelCapacity)
            {
                Fuel = Fuel + fuel;
                return "fuel filled";
            }
            return "fuel exceeds the fuel capacity";

        }
        public string ToString()
        {
            return $"Model: {Model},Color: {Color},Price: {Price},Fuel: {Fuel},Fuelcapacity: {FuelCapacity}";
        }
       
    }
}
