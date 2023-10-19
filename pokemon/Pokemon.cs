
public class Pokemon
{
    private int _index;
    private int _gen;
    private string _name;
    private string _type1;
    private string _type2;
    private double _height;
    private double _weight;

    public Pokemon()
    {
        _name = "";
        _type1 = "";
        _type2 = "";
    }

    public Pokemon(int index, int gen, string name, string type1, string type2, double height, double weight)
    {
        _index = index;
        _gen = gen;
        _name = name;
        _type1 = type1;
        _type2 = type2;
        _height = height;
        _weight = weight;
    }
    public void Display()
    {
        Console.WriteLine($"Id: {_index} | Gen: {_gen} | Name: {_name} | Type1: {_type1} | Type2: {_type2} | Average Height: {_height} | Average Weight: {_weight}");
    }
    public void CreateFromList(string[] parts)
    {
        _index = int.Parse(parts[0]);
        _gen = int.Parse(parts[1]);
        _name = parts[2];
        _type1 = parts[3];
        _type2 = parts[4];
        _height = double.Parse(parts[5]);
        _weight = double.Parse(parts[6]);
    }
    public string Stringify()
    {
        return $"{_index}|||{_gen}|||{_name}|||{_type1}|||{_type2}|||{_height}|||{_weight}";
    }
    public bool IsGen(int gen)
    {
        if (_gen == gen)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsType(int tNum, string type)
    {
        string t = $"type{tNum}";
        if (t == "type1")
        {
            if (_type1 == type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (_type2 == type)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
