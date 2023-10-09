public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public string FractionString()
    {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
    }

    public double decimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}