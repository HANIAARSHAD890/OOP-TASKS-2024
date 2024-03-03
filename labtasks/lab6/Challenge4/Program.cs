using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            MUser user1 = new MUser("Hania", "123");
            Follower follower1 = new Follower("Salman", user1);
            string option = "-1";
            string MainOption = "-1";
            while (MainOption != "0")
            {
                UtilityConsoleUI.MainMenu();
                MainOption = Console.ReadLine();
                if (MainOption == "1")
                {
                    while (option != "0")
                    {
                        UtilityConsoleUI.MenuUser();
                        option = Console.ReadLine();

                        if (option == "1")
                        {
                            user1.GetPosts().Add(PostUI.CreationofPost());
                            Console.WriteLine("Post added");
                        }
                        else if (option == "2")
                        {
                            user1.ViewAllPosts();
                            Console.WriteLine("which post has to be deleted(enter no) ?");
                            int postno = int.Parse(Console.ReadLine());
                            user1.GetPosts().RemoveAt(postno);
                        }
                        else if (option == "3")
                        {
                            user1.ViewAllPosts();
                        }
                        else if (option == "4")
                        {
                            user1.ViewFollowers();
                        }

                        else if (option == "5")
                        {

                            user1.GetPosts()[0].ViewComments();

                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (MainOption == "2")

                {
                    string Followeroption = "-1";
                    while (Followeroption != "0")
                    {

                        UtilityConsoleUI.MenuFollower();
                        Followeroption = Console.ReadLine();

                        if (Followeroption == "1")
                        {
                            follower1.FollowUser().Add(follower1);
                        }

                        if (Followeroption == "2")
                        {
                            Console.WriteLine("ADD COMMENT");
                            follower1.Comment().Add(Console.ReadLine());
                        }
                        if (Followeroption == "3")
                        {
                            Console.WriteLine("Give like");
                            follower1.Likes().Add(Console.ReadLine());
                        }
                        if (Followeroption == "4")
                        {
                            user1.ViewAllPosts();
                        }

                        Console.ReadKey();
                        Console.Clear();




                    }
                }
                MainOption = " -1";
                Console.ReadKey();
                Console.Clear();
            }
            }
           
           
        
    }
}
