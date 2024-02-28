using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Author
    {
        private string Name;
        private string Email;
        private char Gender;
        public Author(string name ,string email,char gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
               
        }
        public  void SetName(string name )
        {
            this.Name = name;

        }
        public string  GetName()
        {
            return Name;

        }

    }
}
