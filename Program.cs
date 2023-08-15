Album TeenageFanClub = new Album();
TeenageFanClub.Name = "Bandwagonesque";

Music music1 = new Music();
Music music2 = new Music();

music1.Name = "Metal Baby";
music2.Name = "I Don't Know";

TeenageFanClub.AddSongAtAlbum(music1);
TeenageFanClub.AddSongAtAlbum(music2);


music1.Duration = 420;
music2.Duration = 300;

TeenageFanClub.ShowSongsFromThisAlbum();


music1.Gender.NameOfGender = "Power Pop";




