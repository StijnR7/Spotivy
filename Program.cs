using System;

namespace Spotivy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            bool go = true;
           
            User currentUser = new("", "");
            bool go2 = true;
            bool go3 = true;
            while (go3) { 
              
            while (go2) {
                Console.WriteLine("[1] Login\n[2] Sign up");
                switch (int.Parse(Console.ReadLine())){
                case 1:
                    Console.WriteLine("Username?: ");
                    string user = Console.ReadLine();
                    Console.WriteLine("Password");
                    string pass = Console.ReadLine();

                    currentUser = data.LoginUser(user, pass);
                        Console.WriteLine("Type 'end' to continue");
                    go2 = Console.ReadLine() != "end";
                            go = true;
                            break;
                case 2:
                    Console.WriteLine("Username? : ");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password? : ");
                    string password = Console.ReadLine();


                    User newUser = new(username, password);
                    data.Users.Add(newUser);
                    currentUser = newUser;
                        Console.WriteLine("Type 'end' to continue");
                        go2 = Console.ReadLine() != "end";
                            go = true;
                        break;

            }
            }
            while (go && currentUser.Username != "")
            {
                Console.WriteLine(
                    "Welcome to Spotivy!\n" +
                    "[1] Search song\n" +
                    "[2] Add song\n" +
                    "[3] Add artist\n" +
                    "[4] Account Details\n" +
                    "[5] New playlist\n" +
                    "[6] Add song to playlist\n" +
                    "[7] View playlist\n" +
                    "[8] View album\n" +
                    "[9] View playing song\n" +
                    "[10] Pause/continue song\n" +
                    "[11] Play album\n" +
                    "[12] Log out\n" +
                    "[13] Add friend\n" +
                    "[14] View friends playlist\n" +
                    "[15] View friends\n" +
                    "[16] Compare playlists\n" +
                    "[17] Play playlist"
                    
                    
                    );
                

                string choice = Console.ReadLine();
                int n = 0;
                int.TryParse(choice, out n);


                if (n == 0)
                {
                    Console.WriteLine("Invalid input");
                    break; ;
                }

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Song name?");
                        Song song = data.FindSong(Console.ReadLine());
                        if (song == null)
                        {
                            Console.WriteLine("Song not found");
                            break;

                        }
                        Console.WriteLine(
                            "Song found!\n" +
                            "[1] Play song\n" +
                            "[2] Add song to playlist\n" +
                            "[3] Details");
                        int num = 0;
                        int.TryParse(Console.ReadLine(), out num);
                        if (num == 0) { Console.WriteLine("Invalid input"); break; }

                        switch (num)
                        {
                            case 1:
                               
                                currentUser.SongPlaying = song;
                                song.PlaySong();
                                break;
                            case 2:
                                //Add user functionality
                                break;
                            case 3:
                                Console.WriteLine(
                                    $"Title: {song.Title}\n" +
                                    $"Album: {song.Album.Title}\n" +
                                    $"Genre: {song.Genre}\n" +
                                    $"Artists: "
                                    );
                                song.ShowArtists();
                                break;

                        }

                        break;
                    case 2:
                        Console.WriteLine("Song title?");
                        string title = Console.ReadLine().ToLower();
                        List<Artist> artists = new();
                        string artistName = "";
                        Console.WriteLine("Artist(s) name(s)?\n Type: 'end' to stop");
                        while (artistName != "end")
                        {


                            artistName = Console.ReadLine().ToLower();
                            Artist foundArtist = data.FindArtist(artistName);
                            if (artistName == "end") { continue; }
                            if (foundArtist == null)
                            {
                                Console.WriteLine("Artist not found.");
                                break;

                            }
                            else
                            {
                                artists.Add(foundArtist);

                            }



                        }
                        Console.WriteLine("[1] Add to album\n[2] Add new album");
                        string albumChoice = Console.ReadLine();
                        Album TheAlbum = new(null, null);
                        string albumNameChosen = "";
                        int albumsLooped = 0;
                        if (albumChoice == "1")
                        {
                            Console.WriteLine("What artist?");
                            Artist chosenArtist = data.ChooseArtistOption(artists);
                            Album chosenAlbum = chosenArtist.chooseAlbum();
                            TheAlbum = chosenAlbum;

                        }

                        else if (albumChoice == "2")
                        {



                            Console.WriteLine("Album name?");
                            albumNameChosen = Console.ReadLine().ToLower();
                            Album tempAlbum = new(albumNameChosen, artists);
                            TheAlbum = tempAlbum;
                            foreach (Artist i in artists)
                            {
                                i.Albums.Add(tempAlbum);

                            }
                        }
                       
                       
                        Console.WriteLine("Genre?");
                       
                        string chosenGenre = data.ChooseGenre();

                        Song finalSong = new(title, artists, chosenGenre, TheAlbum);
                        TheAlbum.Songs.Add(finalSong);  
                        data.AllSongs.Add(finalSong);


                        break;
                    case 3:
                        Console.WriteLine("Artist name");

                        Artist artist = new Artist(Console.ReadLine().ToLower());
                        data.Artists.Add(artist);
                        break;
                    case 4:
                        data.ShowAccountDetails(currentUser);
                        break;
                    case 5:
                        Console.WriteLine("Playlist name: ");
                        Playlist playlist = new(Console.ReadLine());
                        currentUser.Playlists.Add(playlist);
                        
                        break;
                    case 6:
                        Playlist thePlaylist = currentUser.ChoosePlaylist();
                        Console.WriteLine("Song name");
                        string songName=  Console.ReadLine();
                        Song theSong = data.FindSong(songName);
                        if(theSong == null) { break; }
                        thePlaylist.Songs.Add(theSong); 
                        break;

                    case 7:
                        Playlist theChosenPlaylist = currentUser.ChoosePlaylist();
                        Console.WriteLine("Choose a song");
                        Song chosenSong = theChosenPlaylist.ChooseSong();
                        currentUser.SongPlaying = chosenSong;
                        chosenSong.PlaySong();
                        break;
                    case 8:
                        Artist artistAl = data.ChooseArtist();
                        Album albumchosen = artistAl.chooseAlbum();
                        Song chosenSong1 = albumchosen.chooseSong();
                        currentUser.SongPlaying = chosenSong1;
                        chosenSong1.PlaySong();
                        

                        break;
                    case 9:
                        if (currentUser.SongPlaying != null && !currentUser.Paused)
                        {
                            currentUser.SongPlaying.PlaySong();

                        }
                        else {
                            Console.WriteLine("No song playing.");
                        }
                        break;
                     case 10:
                        currentUser.Paused = !currentUser.Paused;
                        string text = currentUser.Paused ? "Paused song" : "Continued playing";
                        Console.WriteLine(text);
                        break;
                    case 11:
                        Artist TheArtistChosen = data.ChooseArtist();
                        Album theAlbumChosen = TheArtistChosen.chooseAlbum();

                        bool continuePlaying = true;
                        Random rand = new Random();
                        while (continuePlaying) {
                            currentUser.SongPlaying = theAlbumChosen.Songs[rand.Next(theAlbumChosen.Songs.Count)];
                            currentUser.SongPlaying.PlaySong();
                            Console.WriteLine(
                                "[0] Next song\n" +
                                "[1] Stop");

                            int optionChosen = int.Parse(Console.ReadLine());
                            if (optionChosen == 1) {
                                continuePlaying = false;
                            }
                        }

                        
                        break;
                    case 12:
                        go = false;
                            go2 = true;
                        break;
                    case 13:
                            User chosenUser = data.ChooseUser();

                            currentUser.Friends.Add(chosenUser);
                            chosenUser.Friends.Add(currentUser);
                            break;
                    case 14:
                            User friendChosen = currentUser.ChooseFriend();
                            Playlist chosenPlaylist = friendChosen.ChoosePlaylist();

                            for(int i = 0; i < chosenPlaylist.Songs.Count; i++)
                            {
                                Console.WriteLine($"[{i}]: {chosenPlaylist.Songs[i].Title}");


                            }
                            break;
                    case 15:

                            for (int i = 0; i < currentUser.Friends.Count; i++) {

                                Console.WriteLine($"[{i}]: {currentUser.Friends[i].Username}");
                            }
                            break;
                    case 16:
                            User friendChosen1 = currentUser.ChooseFriend();
                            Playlist chosenPlaylist1 = friendChosen1.ChoosePlaylist();

                            Playlist chosenPlaylist2 = currentUser.ChoosePlaylist();

                            data.ComparePlaylists(chosenPlaylist1, chosenPlaylist2);


                            break;
                        case 17:
                           Playlist playlist1 = currentUser.ChoosePlaylist();

                            bool continuePlaying1 = true;
                            Random rand1 = new Random();
                            while (continuePlaying1)
                            {
                                currentUser.SongPlaying = playlist1.Songs[rand1.Next(playlist1.Songs.Count)];
                                currentUser.SongPlaying.PlaySong();
                                Console.WriteLine(
                                    "[0] Next song\n" +
                                    "[1] Stop");

                                int optionChosen1 = int.Parse(Console.ReadLine());
                                if (optionChosen1 == 1)
                                {
                                    continuePlaying1 = false;
                                }
                            }


                            break;

                    }
            }
            }

        }
    }
}
