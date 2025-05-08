using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Artist
    {
        private string name;
        private List<Song> songs = new();
        private List<Album> albums = new();

        public Artist(string name, List<Song> songs, List<Album> albums)
        {
            this.name = name;
            this.songs = songs;
            this.album = albums;
        }

        public string Name { get => name; set => name = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }
        internal List<Album> Albums { get => albums; set => albums = value; }
    }
}
