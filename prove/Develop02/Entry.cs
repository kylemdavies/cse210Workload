// Not a part of main program, was just testing to see what it would look like if I had done it like we did in class. (Incomplete)

public class Entry
{
    string _date;
    string _prompt;
    string _entry;

    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _prompt = prompt;
        _entry = entry;
    }

    public void getEntry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string entryPrompt = prompt.Prompt();
        Console.WriteLine(entryPrompt);
        string userResponse = Console.ReadLine();
    }
    
    public void displayEntry()
    {
        Console.WriteLine($"{_date} | {_prompt} - {_entry}");
    }
}