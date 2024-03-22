using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Audi:Car
    {

        private double FuelCapacity=100;
        private string EngineType="";
        private double  Fuel;
        public Audi(string color, string model, double price,double fuelCapacity,string engineType,double fuel):base(color, model, price)
        {
            Color= color;
            Model = model;
            Price = price;
            FuelCapacity = fuelCapacity;
            Fuel = fuel;
            EngineType = engineType;


        }
        public void  FuelConsumed(double distance)
        {
          double consumed= distance /0.5;
            Fuel = Fuel - consumed;
         
        }
        public string FuelFilling(double fuel)
        {
            if (Fuel+fuel<FuelCapacity) 
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
