using System.Reflection.Metadata.Ecma335;

class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ShortResume => $"The song {Name} belongs to the artist {Artist}";

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Artist: { this.Artist}");
        Console.WriteLine($"Duration: {this.Duration}");
        if (Available)
        {
            Console.WriteLine($"Available: it's available");
        } else
        {
            Console.WriteLine("$Available: it isn't available");
        }
        
    }


   
}



