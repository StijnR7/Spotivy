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

        public Artist(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }
        internal List<Album> Albums { get => albums; set => albums = value; }
    }
}