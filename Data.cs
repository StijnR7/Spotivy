using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    internal class Data
    {

        public List<Song> AllSongs = new();
        public List<Artist> Artists = new();



        public Song FindSong(string songName)
        {
            return AllSongs.Where(i => i.Title== songName).FirstOrDefault();
            
        }
        public Artist FindArtist(string artistName)
        {
            return Artists.Where(i => i.Name == artistName).FirstOrDefault();

        }

        public Artist ChooseArtistOption(List<Artist> artists) {
            for (int i = 0; i < artists.Count; i++) { 
            
                Console.WriteLine($"[{i}]: {artists[i].Name}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return artists[n];  }
        
        }
        public Album chooseAlbum(List<Album> albums)
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
