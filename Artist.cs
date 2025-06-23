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

        public Album chooseAlbum()
        {
            for (int i = 0; i < albums.Count; i++)
            {

                Console.WriteLine($"[{i}]: {albums[i].Title}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return albums[n]; }

        }
    }
}