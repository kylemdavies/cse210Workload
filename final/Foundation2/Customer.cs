public class Customer
{
    public string _name;
    private Address _address;
    public Customer(string name,Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsUSA()
    {
        return _address.getUSA();
    }
    public Address getAddress()
    {
        return _address;
    }
}