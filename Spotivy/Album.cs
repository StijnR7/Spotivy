using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Album
    {
        private string title;
        private List<Song> songs;
        private List<Artist> artists;

        public string Title { get => title; set => title = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }
        internal List<Artist> Artists { get => artists; set => artists = value; }
    }
}
