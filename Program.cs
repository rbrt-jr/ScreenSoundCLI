/*Band teenageFanClub = new Band("Teenage Fan Club");
Album bandwagonesque = new Album("Bandwagonesque");

Music music1 = new Music(teenageFanClub, "Metal Baby")
{
    Duration = 420,
    Available = false,
};
Music music2 = new Music(teenageFanClub, "I Don't Know")
{
    Duration = 300,
    Available = true,
   
};

bandwagonesque.AddSongAtAlbum(music1);
bandwagonesque.AddSongAtAlbum(music2);


music1.Gender.NameOfGender = "Power Pop";


teenageFanClub.AddAlbum(bandwagonesque);
teenageFanClub.ShowAlbum();
music1.ShowDetails();

*/

Episode ep1 = new Episode(30, 33, "First Episode");
ep1.AddGuest("Julio Piccone");
string e = ep1.Resume;
Console.WriteLine(e);

Episode ep12 = new Episode(24, 12, "Second Episode");
ep12.AddGuest("Lucas Montano");
string e2 = ep12.Resume;
Console.WriteLine(e2);

Podcast podpah = new("Maurício Meireles", "Getting by in Lisbon");

podpah.AddEpisode(ep12);
podpah.AddEpisode(ep1);
podpah.ShowDetailsOfPodcasts();




