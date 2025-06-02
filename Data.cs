using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Data
    {

        public List<Song> AllSongs = new();
        public Song FindSong(string songName)
        {
            return AllSongs.Where(i => i.Title== songName).FirstOrDefault();
            
        }

    }
}
