FileHandler file = new FileHandler();
Pokedex user = new Pokedex();
user.SetPokedex(file.ReadFile());
int Choice = 0;
while(Choice != 5)
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1: Display Pokedex");
    Console.WriteLine("2: Find Pokemon");
    Console.WriteLine("3: Who's that Pokemon?");
    //Display Pokedex
    if(Choice == 1)
    {
        user.DisplayPokedex();
    }
    //Find Pokemon
    else if(Choice == 2)
    {
        int subChoice = 0;
        //Find Pokemon By name
        if (subChoice == 1)
        {

        }
    }
}