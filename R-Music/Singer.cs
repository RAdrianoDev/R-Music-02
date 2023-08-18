class Singer
{
    private List<Album> albums = new List<Album>();

    public Singer(string singerName)
    {
        SingerName = singerName;
    }

    public string SingerName { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discography of {SingerName}.");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.AlbumName}.({album.TotalAlbumLengthTime}) .");
        }
    }
}