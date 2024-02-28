using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Exercise
    {
         private string Name;
         private  string Duration;
        public Exercise (string name ,string duration)
        {
            Name = name;
            Duration = duration;
        }
        public string GetName()
        {
            return Name;
        }
        public void Setname(string name)
        {
           Name =  name;
        }
    }
}
