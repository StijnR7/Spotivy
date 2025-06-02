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
        private string songPlaying = "";
        private List<Playlist> playlists = new();
        private List<Song> likedSongs = new();
        private List<User> friends = new();

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string SongPlaying { get => songPlaying; set => songPlaying = value; }
        internal List<Playlist> Playlists { get => playlists; set => playlists = value; }
        internal List<Song> LikedSongs { get => likedSongs; set => likedSongs = value; }
        internal List<User> Friends { get => friends; set => friends = value; }
    }
}