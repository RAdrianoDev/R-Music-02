Singer feiYuChing = new Singer("Fei Yu Ching");

Album albumFeiYuChing = new Album("Those Were The Days When My Heart Was (Remastered)"); //font.https://www.deezer.com/en/album/41858721


Music music1 = new Music(feiYuChing, "Those Were The Days When My Heart Was (Remastered)")
{
    LengthTime = 318,
    Availability = true,
};

Music music2 = new Music(feiYuChing, "You're My Forever Nostalgia (Remastered)")
{
    LengthTime = 284,
    Availability = false,
};

Music music3 = new Music(feiYuChing, "Heart Thoughts (Remastered)")
{
    LengthTime = 272,
    Availability = true,
};

Music music4 = new Music(feiYuChing, "Along The Way (Remastered)")
{
    LengthTime = 263,
    Availability = true,
};

Music music5 = new Music(feiYuChing, "Goodbye Yesterday (Remastered)")
{
    LengthTime = 277,
    Availability = true,
};

Music music6 = new Music(feiYuChing, "Forever (Remastered)")
{
    LengthTime = 358,
    Availability = true,
};

Music music7 = new Music(feiYuChing, "Dreaming Of You (Remastered)")
{
    LengthTime = 277,
    Availability = false,
};

Music music8 = new Music(feiYuChing, "Freedom (Remastered)")
{
    LengthTime = 353,
    Availability = false,
};

Music music9 = new Music(feiYuChing, "The Final Chapter (Remastered)")
{
    LengthTime = 256,
    Availability = false,
};

Music music10 = new Music(feiYuChing, "Those Were The Days (Remastered)")
{
    LengthTime = 165,
    Availability = false,
};

albumFeiYuChing.AddMusic(music1);
albumFeiYuChing.AddMusic(music2);
albumFeiYuChing.AddMusic(music3);
albumFeiYuChing.AddMusic(music4);
albumFeiYuChing.AddMusic(music5);
albumFeiYuChing.AddMusic(music6);
albumFeiYuChing.AddMusic(music7);
albumFeiYuChing.AddMusic(music8);
albumFeiYuChing.AddMusic(music9);
albumFeiYuChing.AddMusic(music10);

feiYuChing.AddAlbum(albumFeiYuChing);


music1.ShowDataSheet();
music2.ShowDataSheet();
albumFeiYuChing.ShowAlbumMusics();
feiYuChing.ShowDiscography();



//Music music1 = new Music();
//music1.MusicName = "Thousand Miles Away";
//music1.SingerName = "Fei Yu-Ching";
//music1.LengthTime = 261;
//music1.Availability = true;


//Music music2 = new Music();
//music2.MusicName = "Unstoppable";
//music2.SingerName = "Sia";
//music2.LengthTime = 218;
//music2.Availability= false;

//music1.ShowDataSheet();
//music2.ShowDataSheet();