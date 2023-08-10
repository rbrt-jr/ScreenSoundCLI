Music musicTest1 = new Music();
musicTest1.Name = "New kid in the town";
musicTest1.Artist = "Eagles";
musicTest1.Duration = 263;
musicTest1.Available=true;



Music musicTest2 = new Music();
musicTest2.Name = "All this love";
musicTest2.Artist = "DeBarge";
musicTest2.Duration = 300;
musicTest2.Available = false;


musicTest1.ShowDetails();
Console.WriteLine(musicTest1.ShortResume);
musicTest2.ShowDetails();
Console.WriteLine(musicTest2.ShortResume);

Console.WriteLine(musicTest1.Sum(4, 6));