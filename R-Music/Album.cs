class Album
{
    private List<Music> musics = new List<Music>();
    public string AlbumName { get; set; }
    public int TotalLengthTime { get; set; }

    public void AddMusic(Music musicName )
    {
        musics.Add ( musicName );
    }

    public void ShowAlbumMusics()
    {
        Console.WriteLine($"Musics from the Album {AlbumName}:\n");
        foreach (var musicName in musics)
        {
            Console.WriteLine($"Music: {musicName.MusicName}");
        }
    }
}