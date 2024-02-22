using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisness1
{
public  class signup
    {
        public string name;
        public string password;
        public string role;

        fooditem ft = new fooditem();
        public signup(string name1, string password1, string role1)
        {
            name = name1;
            password = password1;
            role = role1;
        }
        public int UISignin(ref string name1, ref string password1)
        {
            Console.WriteLine("Name: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Password: ");
            password1 = Console.ReadLine();
            return 0;
        }
        public string Signin(ref int usercount, ref string name1, ref string signuprole, ref string password1, ref int currentitration, List<signup> peopleList)
        {
            if (checksignin(ref name1, ref usercount, ref password1, ref currentitration, peopleList))
            {
                string answer = "";
                Console.WriteLine("Successfully sign in");
                answer = peopleList[currentitration].role;
                return role;
            }
            else
            {
                Console.WriteLine("Sorry, Failed to sign in. Try again.");
                Console.WriteLine("Press any key to continue:");
                return "0";
            }
        }
        public bool checksignin(ref string name1, ref int usercount, ref string password1, ref int currentitration, List<signup> peoplelist)
        {
            for (int k = 0; k < usercount; k++)
            {

                if ((peoplelist[k].name == name1) && (peoplelist[k].password == password1))
                {

                    currentitration = k;
                    return true;

                }


            }
            return false;
        }
    }
}
