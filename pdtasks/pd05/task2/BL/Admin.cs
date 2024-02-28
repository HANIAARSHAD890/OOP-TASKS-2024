using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Admin
    {
        public string Username;
        public string Password;
        public Admin(string name ,string password)
        { 
            Username = name;    
            Password = password;
        }  
    }
}
