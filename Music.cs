class Music
{
    public string name;
    public string artist;
    public int duration;
    public bool available;

    public void ShowDetails()
    {
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"Artist: { this.artist}");
        Console.WriteLine($"Duration: {this.duration}");
        if (available)
        {
            Console.WriteLine($"Available: it's available");
        } else
        {
            Console.WriteLine("$Available: it isn't available");
        }
        
    }
}



