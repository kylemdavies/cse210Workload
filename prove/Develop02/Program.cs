using System;

class Program
{
    static void Main(string[] args)
    {
        string attentionLine = "-----------------------------------------------";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Hello today is: {dateText}");
        int number = 0;
        Journal entry = new Journal();
        while (number != 5)
        {
            Console.WriteLine($"What would you like to do today?");
            Console.WriteLine($"1: Make a Journal Entry");
            Console.WriteLine($"2: View Your Entries");
            Console.WriteLine($"3: Load Entries");
            Console.WriteLine($"4: Save Entries");
            Console.WriteLine($"5. Close Program");
            Console.WriteLine($"Enter the number of the action you would like to do:");
            number = int.Parse(Console.ReadLine());
            //Make entry
            if (number == 1) {
                Console.WriteLine(attentionLine);
                entry.Entry();
                Console.WriteLine(attentionLine);
            }
            //Display entries
            else if (number == 2) {
                Console.WriteLine(attentionLine);
                entry.Display();
                Console.WriteLine(attentionLine);
            }
            //Load entries
            else if (number == 3) {
                Console.WriteLine(attentionLine);
                Console.WriteLine("Please enter the filename (Ex. 'filename')");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines($"{filename}.txt");
                foreach (string line in lines)
                {
                    entry._entries.Add(line);
                }
                Console.WriteLine("Entries have been successfully loaded.");
                Console.WriteLine(attentionLine);
            }
            //Save entries
            else if (number == 4) {
                Console.WriteLine(attentionLine);
                Console.WriteLine("Please enter the filename (Ex. 'filename.txt')");
                string fileName = Console.ReadLine();
                System.IO.File.WriteAllLines($"{fileName}.txt", entry._entries);
                Console.WriteLine($"You successfully saved your entries to {fileName}");
                Console.WriteLine(attentionLine);
                }
            //Number entered is too high error
            else if (number >= 6) {
                Console.WriteLine(attentionLine);
                Console.WriteLine($"I'm sorry {number} is not an option please try another number!");
                Console.WriteLine(attentionLine);
            }
            //Close Program
            else {
                Console.WriteLine(attentionLine);
                Console.WriteLine($"Please come again!");
                Console.WriteLine(attentionLine);
            }
        }
    }
}