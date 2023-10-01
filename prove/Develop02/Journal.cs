public class Journal
{
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();

    public List<string>_entries = new List<string>();

        
    public void Entry()
    {
        PromptGenerator prompt = new PromptGenerator();
        Console.WriteLine(prompt.Prompt());
        string userResponse = Console.ReadLine();

        _entries.Add($"{dateText} | {prompt} - {userResponse}");
    }

    public void Display()
    {
        foreach(string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}