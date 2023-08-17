class Album
{
    private List<Music> musics = new List<Music>();

    public Album(string albumName)
    {
        AlbumName = albumName;
    }

    public string AlbumName { get; }
    public int TotalAlbumLengthTime => musics.Sum(musicTime => musicTime.LengthTime);//use a variable to get Music Length time from music.cs

    public void AddMusic(Music musicName)
    {
        musics.Add(musicName);
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Musics from the Album {AlbumName}:\n");
        foreach (var musicName in musics)
        {
            Console.WriteLine($"Music: {musicName.MusicName}");
        }
        Console.WriteLine($"\nThis Album has {TotalAlbumLengthTime} seconds of duration.");
    }
}