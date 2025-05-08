using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Playlist
    {
        private List<Song> songs;

        internal List<Song> Songs { get => songs; set => songs = value; }
    }
}
