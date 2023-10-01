public class Journal
{
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    public List<string>_entries = new List<string>();

        
    public void Entry()
    {
        PromptGenerator prompt = new PromptGenerator();
        string entryPrompt = prompt.Prompt();
        Console.WriteLine(entryPrompt);
        string userResponse = Console.ReadLine();

        _entries.Add($"{dateText} | {entryPrompt} - {userResponse}");
    }

    public void Display()
    {
        foreach(string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}