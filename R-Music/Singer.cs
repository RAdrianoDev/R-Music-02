class Singer
{
    private List<Album> albums = new List<Album>();
    public string SingerName { get; set; }

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