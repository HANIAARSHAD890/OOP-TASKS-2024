using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class AdminCRUD
    {
        public static string  UpdateProfile(Admin a)
        {
            Console.WriteLine("Write name ");
            a.Username = Console.ReadLine();
            Console.WriteLine("Write password");
            a.Password = Console.ReadLine();
            return "profile updated";
        }
        public static void ViewProfile(Admin a)
        {
            Console.WriteLine($" name: {a.Username}");

            Console.WriteLine($"password: {a.Password}");

        }
    }
}
