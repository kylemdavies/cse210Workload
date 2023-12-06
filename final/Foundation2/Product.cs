public class Product
{
    public string _name;
    public int _ID;
    private double _price;
    private int _quantity;
    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }
    public double getPrice()
    {
        return _price * _quantity;
    }
}