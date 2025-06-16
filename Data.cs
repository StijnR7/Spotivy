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
        private List<User> users = new();

        internal List<User> Users { get => users; set => users = value; }


        public User LoginUser(string user, string pass)
        {

            return users.Where(i => i.Username == user).Where(i => i.Password == pass).FirstOrDefault();
        }
        public Song FindSong(string songName)
        {
            return AllSongs.Where(i => i.Title == songName).FirstOrDefault();
            
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
       
        public string ChooseGenre() {
            for (int i = 0; i < Enum.GetNames(typeof(Genre)).Length; i++)
            {
                Console.WriteLine($"{i} {Enum.GetNames(typeof(Genre))[i]}");

            }
            int genreChoice = int.Parse(Console.ReadLine());
            return Enum.GetNames(typeof(Genre))[genreChoice];
        }
        public void ShowAccountDetails(User user) {

            Console.WriteLine($"Username: {user.Username}\n Password: {user.Password}");
        }
        public Artist ChooseArtist() {
            for (int i = 0; i < Artists.Count; i++)
            {

                Console.WriteLine($"[{i}]: {Artists[i].Name}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return Artists[n]; }
        }

        public User ChooseUser() {

            for (int i = 0; i < users.Count; i++)
            {

                Console.WriteLine($"[{i}]: {users[i].Username}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return users[n]; }
        }
        public void ComparePlaylists(Playlist list1, Playlist list2) { 
            List<Song> incommon = new List<Song>();

            foreach (Song song in list1.Songs) {
                foreach (Song song2 in list2.Songs) {
                    if (song == song2) {
                        incommon.Add(song);
                    }
                
                }
            }
            for (int i = 0; i < incommon.Count; i++) {
                Console.WriteLine($"[{i}]: {incommon[i].Title}");
            }
        }
    }


}
