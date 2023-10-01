public class PromptGenerator
{
    static string[] prompts = {"What was your favorite thing you did today?", "What is something you learned today?", "How do you feel about today? Why?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the sillyist thing that happened today?"};
    static public List<string> _promptsList = new List<string>(prompts);
    static int promptsCount = _promptsList.Count;
    static Random rnd = new Random();
    public string Prompt()
    {
        int num = rnd.Next(promptsCount);
        string prompt = (_promptsList[num]);
        return prompt;
    }
}