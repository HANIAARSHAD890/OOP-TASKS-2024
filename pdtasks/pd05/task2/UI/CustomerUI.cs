using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class CustomerUI
    {
        public static void CustomerMenu()
        {
            Console.WriteLine("Regular User Menu:");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Find Product with Highest Unit Price");
            Console.WriteLine("3. View Sales Tax of All Products");
            Console.WriteLine("4. Exit");
        }
        public static Customer InputForCustomer()
        {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password = Console.ReadLine();

        Console.WriteLine("Enter email:");
        string email = Console.ReadLine();

        Console.WriteLine("Enter address:");
        string address = Console.ReadLine();

        Console.WriteLine("Enter contact number:");
        string contactno = Console.ReadLine();
            for (int i = 0; i < CustomerCRUD.ListofCustomer.Count; i++)
            {
                if ((username != CustomerCRUD.ListofCustomer[i].Username) &&( email!= CustomerCRUD.ListofCustomer[i].Email))
                {
                Customer c = new Customer(username, password, email, address, contactno);
                return c;


            }
        }
            return null;
         }
           
                    

}
}
