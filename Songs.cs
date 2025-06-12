namespace MyApplication
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public TimeSpan Time { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Song> songs = new List<Song>
            {
                new Song { Title = "Bohemian Rhapsody", Artist = "Queen", Genre = "Rock", Time = new TimeSpan(0, 5, 55) },
                new Song { Title = "Imagine", Artist = "John Lennon", Genre = "Pop", Time = new TimeSpan(0, 3, 3) },
                new Song { Title = "Billie Jean", Artist = "Michael Jackson", Genre = "Pop", Time = new TimeSpan(0, 4, 54) },
                new Song { Title = "Smells Like Teen Spirit", Artist = "Nirvana", Genre = "Grunge", Time = new TimeSpan(0, 5, 1) },
                new Song { Title = "Hey Jude", Artist = "The Beatles", Genre = "Rock", Time = new TimeSpan(0, 7, 11) },
                new Song { Title = "Like a Rolling Stone", Artist = "Bob Dylan", Genre = "Folk Rock", Time = new TimeSpan(0, 6, 13) },
                new Song { Title = "Hotel California", Artist = "Eagles", Genre = "Rock", Time = new TimeSpan(0, 6, 30) },
                new Song { Title = "Shake It Off", Artist = "Taylor Swift", Genre = "Pop", Time = new TimeSpan(0, 3, 39) },
                new Song { Title = "Blinding Lights", Artist = "The Weeknd", Genre = "Synthpop", Time = new TimeSpan(0, 3, 20) },
                new Song { Title = "Uptown Funk", Artist = "Mark Ronson ft. Bruno Mars", Genre = "Funk", Time = new TimeSpan(0, 4, 30) },
                new Song { Title = "Rolling in the Deep", Artist = "Adele", Genre = "Soul", Time = new TimeSpan(0, 3, 48) },
                new Song { Title = "Lose Yourself", Artist = "Eminem", Genre = "Hip-Hop", Time = new TimeSpan(0, 5, 26) },
                new Song { Title = "Sweet Child O' Mine", Artist = "Guns N' Roses", Genre = "Hard Rock", Time = new TimeSpan(0, 5, 56) },
                new Song { Title = "Thinking Out Loud", Artist = "Ed Sheeran", Genre = "Pop", Time = new TimeSpan(0, 4, 41) },
                new Song { Title = "Hallelujah", Artist = "Leonard Cohen", Genre = "Folk", Time = new TimeSpan(0, 4, 39) },
                new Song { Title = "Shape of You", Artist = "Ed Sheeran", Genre = "Pop", Time = new TimeSpan(0, 3, 53) },
                new Song { Title = "Stairway to Heaven", Artist = "Led Zeppelin", Genre = "Rock", Time = new TimeSpan(0, 8, 2) },
                new Song { Title = "Bad Guy", Artist = "Billie Eilish", Genre = "Electropop", Time = new TimeSpan(0, 3, 14) },
                new Song { Title = "Radioactive", Artist = "Imagine Dragons", Genre = "Alternative Rock", Time = new TimeSpan(0, 3, 6) },
                new Song { Title = "Someone Like You", Artist = "Adele", Genre = "Pop", Time = new TimeSpan(0, 4, 45) }
            };
        }
    }
}