using System.Reflection.Metadata.Ecma335;

class Music
{
    public Music(Band artist, string name)
    {
        this.Artist = artist;
        this.Name = name;
     //   this.Gender.NameOfGender 
    } 
    
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string ShortResume => $"The song {Name} belongs to the artist {Artist.Name}";

    public Gender Gender = new Gender(); 
    public void ShowDetails()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Artist: { this.Artist.Name}");
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



