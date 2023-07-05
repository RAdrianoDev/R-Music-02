Singer feiYuChing = new Singer();
feiYuChing.SingerName = "Fei Yu Ching";


Album albumFeiYuChing = new Album(); //font: https://www.deezer.com/en/album/41858721
albumFeiYuChing.AlbumName = "Those Were The Days When My Heart Was (Remastered)";

Music music1 = new Music(feiYuChing);
music1.MusicName = "Those Were The Days When My Heart Was (Remastered)";
music1.LengthTime = 318;

Music music2 = new Music(feiYuChing);
music2.MusicName = "You're My Forever Nostalgia (Remastered)";
music2.LengthTime = 284;

Music music3 = new Music(feiYuChing);
music3.MusicName = "Heart Thoughts (Remastered)";
music3.LengthTime = 272;

Music music4 = new Music(feiYuChing);
music4.MusicName = "Along The Way (Remastered)";
music4.LengthTime = 263;

Music music5 = new Music(feiYuChing);
music5.MusicName = "Goodbye Yesterday (Remastered)";
music5.LengthTime = 277;

Music music6 = new Music(feiYuChing);
music6.MusicName = "Forever (Remastered)";
music6.LengthTime = 358;

Music music7 = new Music(feiYuChing);
music7.MusicName = "Dreaming Of You (Remastered)";
music7.LengthTime = 277;

Music music8 = new Music(feiYuChing);
music8.MusicName = "Freedom (Remastered)";
music8.LengthTime = 353;

Music music9 = new Music(feiYuChing);
music9.MusicName = "The Final Chapter (Remastered)";
music9.LengthTime = 256;

Music music10 = new Music(feiYuChing);
music10.MusicName = "Those Were The Days (Remastered)";
music10.LengthTime = 165;

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

albumFeiYuChing.ShowAlbumMusics();


feiYuChing.AddAlbum(albumFeiYuChing);
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