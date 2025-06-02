using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotivy;

namespace Spotivy
{
    internal class Song
    {
        private string title;
        private List<Artist> artists = new();
        private Genre genre;

        public Song(string title, List<Artist> artists, Genre genre)
        {
            this.title = title;
            this.artists = artists;
            this.genre = genre;
        }

        public string Title { get => title; set => title = value; }
        public Genre Genre { get => genre; set => genre = value; }
        internal List<Artist> Artists { get => artists; set => artists = value; }
    }
}