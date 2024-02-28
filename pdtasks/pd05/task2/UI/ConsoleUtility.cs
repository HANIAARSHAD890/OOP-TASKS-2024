using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ConsoleUtility
    {
        public static void MainMenu()
        {
            Console.WriteLine("1.Sign in ");
            Console.WriteLine("2.Sign up ");
            Console.WriteLine("3.Exit ");
        }
        public static string  InputForSignin()
            {
            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();
            Console.WriteLine("enter Password");
            string password = Console.ReadLine();
            for (int i = 0; i < CustomerCRUD.ListofCustomer.Count; i++)
            {
                if (name == CustomerCRUD.ListofCustomer[i].Username && password == CustomerCRUD.ListofCustomer[i].Password)
                {
                  
                    return "Customer";
                }
                else if ((name == "HaniaArshad") && (password == "123"))
                    {
                    return "Admin";
                }

               
            }
            return "Invalid values entered";



        }
   
    }
}
