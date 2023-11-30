List<Video> videos = new List<Video>();
Comment c1 = new Comment("StevenStrange1", "first");
Comment c2 = new Comment("wewillrockyou", "Whoa!");
Comment c3 = new Comment("user12323987", "I think I saw this in a movie once.");
Video v1 = new Video("I went to Disneyland", "Mark Iplier", 900);
v1.AddComment(c1);
v1.AddComment(c2);
v1.AddComment(c3);
videos.Add(v1);
Comment co1 = new Comment("Chevy", "XD");
Comment co2 = new Comment("Br1dger", "OMG I'd trade my sister for 3 emeralds");
Comment co3 = new Comment("CH@$E", "#freechevy");
Video v2 = new Video("Chevy caught with miners?!?! Minecraft hardcore ep. 115", "Prestqon", 1020);
v2.AddComment(co1);
v2.AddComment(co2);
v2.AddComment(co3);
videos.Add(v2);
Comment com1 = new Comment("bionicles4lyfe", "Whoa that was a close one!");
Comment com2 = new Comment("n33d4f33t", "How can one get these morning feet pics?!");
Comment com3 = new Comment("TheClosers", "That's my expert!");
Video v3 = new Video("filming my roomate without him knowing challenge", "Not Prestqons Roomate", 86400);
v3.AddComment(com1);
v3.AddComment(com2);
v3.AddComment(com3);
videos.Add(v3);
foreach (Video video in videos)
{
    video.DisplayVideo();
}