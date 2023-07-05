Music music1 = new Music();
music1.musicName = "Thousand Miles Away";
music1.singerName = "Fei Yu-Ching";
music1.lengthTime = 261;
music1.WriteAvailability(true);


Music music2 = new Music();
music2.musicName = "Unstoppable";
music2.singerName = "Sia";
music2.lengthTime = 218;
music2.WriteAvailability(false);

music1.ShowDataSheet();
music2.ShowDataSheet();
