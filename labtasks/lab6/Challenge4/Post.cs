using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Post
    {
        private List<string> Comments;
        private List<string>Likes;
        private string Title;
        private string Body;
        private string ImageURL;
        public Post(string title, string body, string imageURL)
        {
            Comments = new List<string>() ;
            Likes=new List<string>();
            Title = title;
            Body = body;
            ImageURL = imageURL;
        }
        public void SetTitle(string title )
        {
            Title = title; 
        }
        public void AddComment(string comment)
        {
            Comments.Add( comment );    
        }
        public void AddLike(string like)
        {
            Likes.Add( like );  
        }
        public List<string> GetComments()
        {
            return Comments ;
        }
        public List<string> GetLikes()
        {
            return Likes;
        }
        public void viewpost()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine($"{Body}");
            Console.WriteLine($"{ImageURL}");
            ViewComments();
            ViewLikes();



        }
        public void ViewComments()
        {
            Console.WriteLine("Comments");
            for (int i = 0; i < Comments.Count; i++)
            {
                Console.WriteLine(Comments[i]); 
            }

        }
        public void ViewLikes()
        {
            Console.WriteLine("Likes");
            int count =0;
            for (int i = 0; i <= Likes.Count; i++)
            {
                count = count + i;
            }
            Console.WriteLine($"likes: {count}");

        }
    }
}
