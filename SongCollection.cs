using MyApplication;

namespace SpotifyCLI;

public class SongCollection
{
    public String Title;
    public List<Song> Songs { get; protected set; } = new();  
    
    public SongCollection(String title)
    {
        Title = title;
        
    }
    
    public virtual void PlayAll()
    {
        foreach (var song in Songs)
        {
            Console.WriteLine($"{song.Title} by {song.Artist} - {song.Time}");
        }
    }

    public virtual void Shuffle()
    {
        var rnd = new Random();
        Songs = Songs.OrderBy(s => rnd.Next()).ToList();
    }
    
}