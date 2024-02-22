using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoConstructors1
{
    internal class angle
    {
        public float deg;
        public float min;
        public char direction;

        public angle(float deg, float min, char direction)
        {
            this.deg = deg;
            this.min = min;
            this.direction = direction;
        }
        public string DisplayAngle()
        {
            return $"{deg}\u00b0{min}'{direction}";
        }
        public string ChangeAngle(ref float deg, ref float min, ref char direction)
        {
            this.deg = deg;
            this.min = min;
            this.direction = direction;
            return "angle updated";




        }
    }
}