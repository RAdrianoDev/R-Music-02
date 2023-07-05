//describing a music. It should have:
//name - musicName
//artist - singer
//music length - lengthTime
//if available on the plan or not - availability

class Music
{
    public string musicName;
    public string singerName;
    public int lengthTime;
    private bool availability;


    public void WriteAvailability(bool value)
    {
        availability = value;
    }

    public bool ReadAvailability() 
    {
        return availability;
    }

    public void ShowDataSheet()
    {
        Console.WriteLine($"Music name: {musicName}");
        Console.WriteLine($"Singer name: {singerName}");
        Console.WriteLine($"Music Length: {lengthTime}");
        if (availability)
        {
            Console.WriteLine("This music is available on your plan!");
        } else
        {
            Console.WriteLine("Not available. Update your plan.");
        }
        
    }
}
