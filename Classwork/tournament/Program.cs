Player p1 = new Player("Christiano Ronaldo", 7);
Player p2 = new Player("Messi", 23);
Team cardinals = new Team("Cardinals");
cardinals.addPlayer(p1);
cardinals.addPlayer(p2);
Player p3 = new Player("Justin Timberlake", 5);
Player p4 = new Player("Jason Derulo", 12);
Team jazz = new Team("Jazz");
jazz.addPlayer(p3);
jazz.addPlayer(p4);

Match m1 = new Match(cardinals, jazz);
m1.DecideWin();

cardinals.DisplayRoster();
jazz.DisplayRoster();

int season = 1;
while(season != 0)
{
    
}