using System.Dynamic;

public class Address
{
    string _streetAd;
    string _city;
    string _state;
    int _zip;
    string _country;
    public Address(string street,string city,string state,int zip,string country)
    {
        _streetAd = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }
    public bool getUSA()
    {
        if (_country.Contains("USA"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string getLetterForm()
    {
        return $"{_streetAd}\n{_city}, {_state} {_zip}\n{_country}";
    }
}