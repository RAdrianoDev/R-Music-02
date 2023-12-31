﻿class Music
{
    public Music(Singer singer, string musicName) 
    {
        SingerName = singer;
        MusicName = musicName;
    }
    
    public string MusicName { get; }
    public Singer SingerName { get; }
    public int LengthTime { get; set; }
    public bool Availability { get; set; }
    public string Description => $"The music {MusicName} belongs to {SingerName}"; //=> read mode (lambda)
    
 



    public void ShowDataSheet()
    {
        Console.WriteLine($"Music name: {MusicName}");
        Console.WriteLine($"Singer name: {SingerName.SingerName}");
        Console.WriteLine($"Music Length: {LengthTime}");
        Console.WriteLine(Description);
        if (Availability)
        {
            Console.WriteLine("This music is available on your plan!");
        } else
        {
            Console.WriteLine("Not available. Update your plan.");
        }
        
    }
}


//describing a music. It should have:
//name - MusicName
//artist - Singer
//music length - LengthTime
//if available on the plan or not - Availability
//join Music Name and Artist - Description