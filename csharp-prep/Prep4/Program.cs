using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> nums = new List<int>();
        int num = 1;
        while(num != 0){
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if(num != 0){
                nums.Add(num);
            }
        }
        int add = 0;
        foreach (int n in nums){
            add += n;
        }
        Console.WriteLine($"The sum is: {add}");
        float avg = add / nums.Count;
        Console.WriteLine($"The average is: {avg}");
        int lNum = 0;
        foreach(int n in nums){
            if (n > lNum){
                lNum = n;
            }
        }
        Console.WriteLine($"The largest number is: {lNum}");
    }
}