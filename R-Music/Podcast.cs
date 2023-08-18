class Podcast
{
    private List<Episode> episodes = new();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalEpisodes => episodes.Count;

    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name} hosted by {Host}\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Order)) //Order by here secure that the system will respect the number you set on episode on file Program.cs and not the oreder that they presented there.
        {
            Console.WriteLine(episode.Summary);
        }
        Console.WriteLine($"\n\nThis Podcast has {TotalEpisodes} epidodes.");
    }
}