using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Songs
    {
        public string Name;
        public string Singer;
        public Songs(string name, string singer)
        {
            Name = name;
            Singer = singer;
        }
        public string GetName()
        {
            return Name;
        }
        public string SetSinger(string name )
        {
            Name = name; 
            return "name updated";
        }
    }
}
