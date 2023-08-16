class Podcast
{
    public Podcast(string host, string name)
    {
        this.Host = host;
        this.Name = name;
    }

    public string Host {get; }

    public string Name { get; }

    private List<Episode> episodes = new List<Episode>();  
    
    public int TotalEpisodes => episodes.Count;
    
    
    public void AddEpisode(Episode episode)
    {
        episodes.Add(episode);
    }

    public void ShowDetailsOfPodcasts()
    {
        Console.WriteLine($"Podcast {Name} showed by {Host}\n\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Sort))
        {
            Console.WriteLine(episode.Resume);
        }
        Console.WriteLine($"\nTotal of episodes are {TotalEpisodes}");
    }  
   
}