using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class calculator
    {
        public double value1;
        public double value2;

        public calculator(double a, double b)
        {
            value1 = a;
            value2 = b;
        }
        public double add()
        {
            return value1 + value2;
        }
        public double multiply()
        {
            return value1 * value2;
        }
        public double divide()
        {

            if (value2 != 0)
            {
                return value1 / value2;
            }
         
            return 0;
        }
        public double modulo()
        {
            return value1 % value2;
        }
        public double subtract()
        {
            return value1 - value2;
        }
        public double squareroot()
        {
            return Math.Sqrt(value1);

        }
        public double log()
        {
            return Math.Log(value1);
        }
        public double power()
        {
            return Math.Pow(value1, value2);
        }
        public double sin()
        {
            return Math.Sin(value1);
        }
        public double cos()
        {
            return Math.Cos(value1);
        }
        public double tan()
        {
            return Math.Tan(value1);
        }
    }
}