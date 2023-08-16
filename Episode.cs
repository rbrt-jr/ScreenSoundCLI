class Episode
{
    private List<string> guestsName = new List<string>();
    public Episode(int duration, int sort, string title)
    {
        this.Duration = duration;
        this.Sort = sort;
        this.Title = title;
    }
    public int Duration { get; }
    public int Sort { get; }
    public string Resume => $"{Sort}. {Title}. ({Duration} min) - {string.Join(", ",guestsName)}";
    public string Title { get; }

    public void AddGuest(string guestName)
    {
        guestsName.Add(guestName);
    }
}