class Episode
{
    private List<string> guests = new();
    public Episode(int order, string title, int totalTime)
    {
        Order = order;
        Title = title;
        TotalTime = totalTime;
    }

    public int Order { get; }
    public string Title { get; }
    public int TotalTime { get; }
    public string Summary => $"{Order}. {Title} ({TotalTime} min) - {string.Join(", ", guests)}";
    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }

}
