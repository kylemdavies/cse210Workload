public class Scripture
{
    private string _verses = "";
    public Scripture(string verse)
    {
        _verses = verse;
    }

    public string getScripture()
    {
        return _verses;
    }
}