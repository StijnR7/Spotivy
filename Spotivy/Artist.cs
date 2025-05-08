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
        private List<Song> songs;
        private List<Album> albums;

        public string Name { get => name; set => name = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }
        internal List<Album> Albums { get => albums; set => albums = value; }
    }
}
