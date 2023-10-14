public class Word
{
    static Random rnd = new Random();
    public string getWord(string scripture)
    {
        string theScripture = scripture;
        List<string> list = theScripture.Split(" ").ToList();
        int count = list.Count;
        int num1 = rnd.Next(count);
        int num2 = rnd.Next(count);
        int num3 = rnd.Next(count);
        while (list[num1] != "___")
        {
            if(list[num1] != "___")
            {
                list[num1] = "___";
            }
            else
            {
                num1 = rnd.Next(count);
            }
        }
        while (list[num2] != "___")
        {
            if(list[num2] != "___")
            {
                list[num2] = "___";
            }
            else
            {
                num2 = rnd.Next(count);
            }
        }
        while (list[num3] != "___")
        {
            if(list[num3] != "___")
            {
                list[num3] = "___";
            }
            else
            {
                num3 = rnd.Next(count);
            }
        }

        theScripture = string.Join(" ", list);
        return theScripture;
    }
}