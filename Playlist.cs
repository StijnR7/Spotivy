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
            this.Name = name;

        }
       
        public Song ChooseSong()
        {
            for (int i = 0; i < songs.Count; i++)
            {

                Console.WriteLine($"[{i}]: {songs[i].Title}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return songs[n]; }

        }
        public string Name { get => name; set => name = value; }

        internal List<Song> Songs { get => songs; set => songs = value; }
    }
}