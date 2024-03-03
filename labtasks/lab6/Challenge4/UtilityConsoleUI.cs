using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class UtilityConsoleUI
    {

        public static void MenuUser()
        {
            Console.WriteLine("Menu for the User");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Add Post");
            Console.WriteLine("2. Delete Post");
            Console.WriteLine("3. View Post Details");
            Console.WriteLine("4. View Followers");
            Console.WriteLine("5. View Comments");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");


        }
        public static void MenuFollower()
        {
            Console.WriteLine("Follower Menu:");
            Console.WriteLine("1. Follow User");
            Console.WriteLine("2. Add Comment");
            Console.WriteLine("3. Give Like");
            Console.WriteLine("4. View Post");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
        }
        public static void  MainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. User Menu");
            Console.WriteLine("2. Follower Menu");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
        }
        

    }
}