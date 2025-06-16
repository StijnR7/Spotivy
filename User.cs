using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Spotivy
{
    internal class User
    {

        private string username;
        private string password;
        private Song songPlaying;
        private bool paused = false;
        private List<Playlist> playlists = new();
        private List<Song> likedSongs = new();
        private List<User> friends = new();

        public User(string username, string password)
        {
            this.username = username;
            this.Password = password;
        }

        public Playlist ChoosePlaylist() {
            for (int i = 0; i < playlists.Count; i++) {
                Console.WriteLine($"[{i}]: {playlists[i].Name}");
            }
            Console.WriteLine("Choose playlist by number: ");
            int choice = int.Parse( Console.ReadLine() );   
            return playlists[choice];
        }
        public User ChooseFriend()
        {

            for (int i = 0; i < friends.Count; i++)
            {

                Console.WriteLine($"[{i}]: {friends[i].username}");
            }
            string choice = Console.ReadLine();
            int n = -1;
            int.TryParse(choice, out n);
            if (n == -1) { Console.WriteLine("Invalid choice"); return null; }
            else { return friends[n]; }
        }
        

        public string Username { get => username; set => username = value; }
        public Song SongPlaying { get => songPlaying; set => songPlaying = value; }
        public string Password { get => password; set => password = value; }
        internal List<Playlist> Playlists { get => playlists; set => playlists = value; }
        internal List<Song> LikedSongs { get => likedSongs; set => likedSongs = value; }
        internal List<User> Friends { get => friends; set => friends = value; }
        public bool Paused { get => paused; set => paused = value; }
    }
}