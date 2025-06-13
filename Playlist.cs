using MyApplication;
namespace SpotifyCLI;

public class Playlist : SongCollection
{
    public bool IsPublic { get; set; }

    public Playlist(String title, bool isPublic = true) : base(title)
    {
        IsPublic = isPublic;
    }

    public void AddSong(Song song)
    {
        Songs.Add(song);
    }
}