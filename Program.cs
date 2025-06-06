using System;

namespace Spotivy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            bool go = true;
            while (go)
            {
                Console.WriteLine(
                    "Welcome to Spotivy!\n" +
                    "[1] Search song\n" +
                    "[2] Add song\n" +
                    "[3] Add artist");


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
                                Console.WriteLine("Now playing: " + song.Title);

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
                        string title = Console.ReadLine();
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
                            Album chosenAlbum = data.chooseAlbum(chosenArtist.Albums);
                            TheAlbum = chosenAlbum;

                        }

                        else if (albumChoice == "2")
                        {



                            Console.WriteLine("Album name?");
                            albumNameChosen = Console.ReadLine();
                            Album tempAlbum = new(albumNameChosen, artists);
                            TheAlbum = tempAlbum;
                            foreach (Artist i in artists)
                            {
                                i.Albums.Add(tempAlbum);

                            }
                        }
                       
                       
                        Console.WriteLine("Genre?");
                        for (int i = 0; i < Enum.GetNames(typeof(Genre)).Length; i++)
                        {
                            Console.WriteLine($"{i} {Enum.GetNames(typeof(Genre))[i]}");

                        }
                        int genreChoice = int.Parse(Console.ReadLine());
                        string chosenGenre = Enum.GetNames(typeof(Genre))[genreChoice];

                        Song finalSong = new(title, artists, chosenGenre, TheAlbum);
                        data.AllSongs.Add(finalSong);


                        break;
                    case 3:
                        Console.WriteLine("Artist name");

                        Artist artist = new Artist(Console.ReadLine().ToLower());
                        data.Artists.Add(artist);
                        break;
                }
            }

        }
    }
}
