using System;

class Program
{
    static void Main(string[] args)
    {
        int cont = 0;
        while(cont != 1){
            Program p = new Program();
            p.DisplayWelcome();
            string name = PromptUserName();
            int num = PromptUserNumber();
            double sqr = SquareNumber(num);
            p.DisplayResult(name,sqr);
            Console.Write("If you would like to close the program Enter \'1\'");
            cont = int.Parse(Console.ReadLine());
        }
    }
    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    public static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    public static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    public static double SquareNumber(int number)
    {
        double square = Math.Pow(number,2);
        return square;
    }
    void DisplayResult(string name, double sqr)
    {
        Console.WriteLine($"{name}, the square of your number is {sqr}");
    }
}