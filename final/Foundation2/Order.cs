using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private int _shipping = 0;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
        if (_customer.IsUSA() == true)
        {
            _shipping = 5;
        }
        else
        {
            _shipping = 35;
        }
    }
    public double getPriceTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.getPrice();
        }
        total += _shipping;
        return total;
    }
    public void getPackingLabel()
    {
        Console.WriteLine("Here is the Packaging Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product._name} | {product._ID}");
        }
    }
    public void getShippingLabel()
    {
        Console.WriteLine("Here is the Shipping Label:");
        Console.WriteLine(_customer._name);
        Console.WriteLine(_customer.getAddress().getLetterForm());
    }
    
}