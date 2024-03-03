using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    internal class Follower
    {
        private string Name;
        private List<MUser> PeopleYouMayKnow = new List<MUser>();

        public Follower(string name,MUser user1 )
        {
            Name = name;
            PeopleYouMayKnow.Add( user1 );      
        }
        public string Getname()
        {
            return Name;
        }
        public void Setname(string name)
        {
            Name = name;
        }
        public List<Follower>FollowUser()
        {
            return PeopleYouMayKnow[0].GetFolllowers();

        }
        public List<string> Comment()
        {
            return PeopleYouMayKnow[0].GetPosts()[0].GetComments();

        }
        public List<string> Likes()
        {
            return PeopleYouMayKnow[0].GetPosts()[0].GetLikes();

        }
    }
}