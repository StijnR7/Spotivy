using System;

namespace Spotivy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            bool go = true;
            while (go) {
            Console.WriteLine(
                "Welcome to Spotivy!\n" +
                "[1] Search song]\n" +
                "[2] Add song");
            string choice = Console.ReadLine();
            int n = 0;
            int.TryParse(choice, out n);


            if (n == 0) {
                Console.WriteLine("Invalid input");
                    break; ;
            }

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Song name?");
                        Song song = data.FindSong(Console.ReadLine());  
                        if(song == null)
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

                        switch (num) {
                            case 1:
                                Console.WriteLine("Now playing: "+song.Title);

                                break;
                            case 2:
                                //Add user functionality
                                break;
                            case 3:
                                Console.WriteLine(
                                    $"Title: {song.Title}\n" +
                                    $"Album: {song.Album}\n" +
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
                        break;
                }
            }

        }
    }
}
