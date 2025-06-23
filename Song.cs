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
        private string genre;
        private Album album;

        public Song(string title, List<Artist> artists, string genre, Album album)
        {
            this.title = title;
            this.artists = artists;
            this.genre = genre;
            this.Album = album;
        }
        public void ShowArtists() {
            foreach (Artist artist in artists) {
                Console.WriteLine(artist.Name);
            }
        }
        public void PlaySong( ) {
            
            Console.WriteLine($"Now playing: {title}");
        
        }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        internal List<Artist> Artists { get => artists; set => artists = value; }
        internal Album Album { get => album; set => album = value; }
    }
}