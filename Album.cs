class Album
{
    public Album(string name)
    {
        this.Name = name;   
    }
    private List<Music> songs = new List<Music>();
    public string Name { get; }
    public int TotalDurationOfThisAlbum => songs.Sum(s => s.Duration);
     
    public void AddSongAtAlbum(Music music)
    {
        songs.Add(music);
    }

    public void ShowSongsFromThisAlbum()
    {
        Console.WriteLine($"List of songs from album {Name}:\n");
        foreach (Music music in songs)
        {
            Console.WriteLine($"Song: {music.Name}");
        }
        Console.WriteLine($"This album has a total of {TotalDurationOfThisAlbum} seconds ");

    }
    

}