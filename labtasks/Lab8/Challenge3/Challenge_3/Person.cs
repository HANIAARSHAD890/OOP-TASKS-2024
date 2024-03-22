using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    internal class Person
    {
        protected string Name;
        protected string Address;
        public Person(string name,string address)
        {
            Name = name;
            Address = address;
        }
        public string GetName()
        {
            return Name;

        }
        public void SetName(string name)
        {
             Name=name;

        }
        public string GetAddress()
        { 
            return Address;
        }
    }
}
