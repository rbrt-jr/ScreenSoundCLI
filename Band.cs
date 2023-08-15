class Band
{
    public Band(string name)
    {
        this.Name = name;
    }
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowAlbum()
    {
        Console.WriteLine($"Discography of {Name}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDurationOfThisAlbum})");
        }
    }
}