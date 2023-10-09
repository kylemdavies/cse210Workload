using System;

class Program
{
    static void Main(string[] args)
    {
        string attentionLine = "-----------------------------------------------";

        Console.WriteLine(attentionLine);
        Fraction type1 = new Fraction();
        Console.WriteLine(type1.FractionString());
        Console.WriteLine(type1.decimalValue());
        Console.WriteLine(attentionLine);

        Console.WriteLine(attentionLine);
        Fraction type2 = new Fraction(5);
        Console.WriteLine(type2.FractionString());
        Console.WriteLine(type2.decimalValue());
        Console.WriteLine(attentionLine);

        Console.WriteLine(attentionLine);
        Fraction type3 = new Fraction(3, 4);
        Console.WriteLine(type3.FractionString());
        Console.WriteLine(type3.decimalValue());
        Console.WriteLine(attentionLine);

        Console.WriteLine(attentionLine);
        Fraction type4 = new Fraction(1, 3);
        Console.WriteLine(type4.FractionString());
        Console.WriteLine(type4.decimalValue());
        Console.WriteLine(attentionLine);    }
}