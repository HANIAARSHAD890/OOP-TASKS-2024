using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class MUser
    {
        private static List<Post>Posts; 
        private static  List<Follower> Followers;
        private string Name;
        private string Password;
        public MUser(string name ,string password)
        {
            Followers = new List<Follower>();
            Posts = new List<Post>();
            Name = name;
            Password = password;    
      }
        public string GetName()
        {
            return Name;
        }
        public string GetPassword()
        {
            return Password;
        }
        public List<Follower> GetFolllowers()
        {
            return Followers;
        }
        public void ViewAllPosts()
        { for (int i = 0; i < Posts.Count; i++)
            {
                Console.WriteLine($"post no: {i}");
                Posts[i].viewpost();
            }

        }
    public  List<Post> GetPosts()
    {
        return Posts;
    }
     public void  Setpassword(string password)
        {
          Password = password;
        }
        public void ViewFollowers()
        {
            for (int i = 0; i < Followers.Count; i++)
            {
                Console.WriteLine($"Follower: {Followers[i].Getname()}");
            }
        }
    }
}
