using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        string Menu = "Menu Options \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit";
        while (Choice != 4)
        {
            //Displays Menu and Reads response
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine());
            if (Choice == 4)
            {
                Console.Clear();
            }
            else if (Choice == 1)
            {
                //Activity Name, Duration, Description
                Console.Clear();
                BreathingActivity activity1 = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(activity1.getStart(activity1.getDescription()));
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine(activity1.setDuration(duration));
            }
            else if (Choice == 2)
            {
                Console.Clear();
                ReflectingActivity activity2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(activity2.getStart(activity2.getDescription()));
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine(activity2.setDuration(duration));
            }
            else if (Choice == 3)
            {
                Console.Clear();
                ListeningActivity activity3 = new ListeningActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine(activity3.getStart(activity3.getDescription()));
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine(activity3.setDuration(duration));
            }
            
        }
    }
}