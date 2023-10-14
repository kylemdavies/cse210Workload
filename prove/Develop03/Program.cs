using System;

class Program
{
    static void Main(string[] args)
    {
        string Choice = "";
        //gets reference and scripture associated with it.
        Reference proverbs = new Reference("Proverbs 3:5-6");
        string scriptureRef = proverbs.getReference();
        Scripture scripture = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string theScripture = scripture.getScripture();

        while (Choice != "quit")
        {
            //Displays original Scripture
            Console.WriteLine($"{scriptureRef}: {theScripture}");
            Console.WriteLine($"Type 'quit' to close the application, and press enter to continue.");
            Choice = Console.ReadLine();
            if (Choice == "quit")
            {
                Console.Clear();
            }
            else
            {
                Word theWords = new Word();
                theScripture = theWords.getWord(theScripture);
                Console.Clear();
            }
            
        }
        Console.Clear();
    }
}