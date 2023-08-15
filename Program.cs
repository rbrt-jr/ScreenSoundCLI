Band teenageFanClub = new Band("Teenage Fan Club");
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





