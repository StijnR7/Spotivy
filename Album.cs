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
        private List<Song> songs = new();
        private List<Artist> artists = new();

        public Album(string title, List<Song> songs, List<Artist> artists)
        {
            this.title = title;
            this.songs = songs;
            this.artists = artists;
        }

        public string Title { get => title; set => title = value; }
        internal List<Song> Songs { get => songs; set => songs = value; }
        internal List<Artist> Artists { get => artists; set => artists = value; }
    }
}