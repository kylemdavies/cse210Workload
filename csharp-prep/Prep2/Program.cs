using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your number grade?");
        int numGrade = int.Parse(Console.ReadLine());
        string lGrade = "";
        if(numGrade >= 90){
            lGrade = "A";
        }
        else if(numGrade >= 80){
            lGrade = "B";
        }
        else if(numGrade >= 70){
            lGrade = "C";
        }
        else if(numGrade >= 60){
            lGrade = "D";
        }
        else{
            lGrade = "F";
        }
        bool pass = true;
        if(numGrade >= 70){
            pass = true;
        }
        else{
            pass = false;
        }
        Console.WriteLine($"Your grade is: {lGrade}.");
        if(pass == true){
            Console.WriteLine("You passed great job!");
        }
        else{
            Console.WriteLine("Darn. Better luck next time!");
        }
    }
}