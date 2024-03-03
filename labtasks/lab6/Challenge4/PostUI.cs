using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class PostUI
    {
        public static Post CreationofPost()
        {
            Console.WriteLine("Enter the title of the post:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the body of the post:");
            string body = Console.ReadLine();

            Console.WriteLine("Enter the URL of the image (optional, press Enter to skip):");
            string imageURL = Console.ReadLine();
            Post post1 = new Post(title, body, imageURL);
            return post1;
        }

    }
}
