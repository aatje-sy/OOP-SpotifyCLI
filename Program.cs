using MyApplication;
using System;
using System.Collections.Generic;

namespace SpotifyCLI;

class Program
{
    static void Main(string[] args)
    {
        List<Song> allSongs = SongLibrary.AllSongs;

        Console.WriteLine("Geef een titel voor je playlist:");
        string title = Console.ReadLine();

        Playlist playlist = new Playlist(title);

        Console.WriteLine("\nBeschikbare liedjes:");
        for (int i = 0; i < allSongs.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {allSongs[i].Title} - {allSongs[i].Artist}");
        }

        Console.WriteLine("\nVoer het nummer van het liedje in dat je wilt toevoegen (of 0 om te stoppen):");
        int choice = int.Parse(Console.ReadLine());

        while (choice != 0)
        {
            if (choice > 0 && choice <= allSongs.Count)
            {
                playlist.AddSong(allSongs[choice - 1]);
                Console.WriteLine("Toegevoegd!");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            }

            Console.WriteLine("Kies nog een nummer of 0 om te stoppen:");
            choice = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"\nJe playlist '{playlist.Title}' bevat de volgende liedjes:");
        playlist.PlayAll();
    }
}