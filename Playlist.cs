using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Playlist
    {
        private string name;
        private List<Song> songs = new();

        public Playlist(string name)
        {
            this.name = name;

        }


        internal List<Song> Songs { get => songs; set => songs = value; }
    }
}