using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Playlist
    {
        private string Name;
       private List<Songs> Listofsongs;
        private Playlist(string name)

        {
            Name = name;
            this.Listofsongs = new List<Songs>();
        }
        public void Add(Songs songs) {

            Listofsongs.Add(songs);
        }
        public  List<Songs>  GetlistOfsongs()
           {
            return Listofsongs;
         }
    }
}
