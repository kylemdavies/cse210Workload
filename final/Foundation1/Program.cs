Comment c1 = new Comment("StevenStrange1", "first");
Comment c2 = new Comment("wewillrockyou", "Whoa!");
Comment c3 = new Comment("user12323987", "I think I saw this in a movie once.");
Video v1 = new Video("I went to Disneyland", "Mark Iplier", 900);
v1.AddComment(c1);
v1.AddComment(c2);
v1.AddComment(c3);
v1.DisplayVideo();