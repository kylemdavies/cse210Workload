using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        int totalPoints =  0;
        List<Goal> goals = new List<Goal>();
        List<string> stringGoals = new List<string>();
        string Menu = "Menu Options \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit";
        while (Choice != 6)
        {
            //Displays Menu and Reads response
            string Break = $"--------------------------------------------- \nPoints: {totalPoints}\n---------------------------------------------";
            Console.WriteLine($"Points: {totalPoints}");
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine());
            Console.WriteLine(Break);
            int Goaltype = 0;
            //Create Goals
            if (Choice == 1)
            {
                Console.WriteLine("1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                Console.WriteLine($"v Select a choice from the menu: ");
                Goaltype = int.Parse(Console.ReadLine());
                Console.WriteLine(Break);
                if (Goaltype == 1)
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.SetGoalType("Simple Goal");
                    sGoal.SetName(name);
                    sGoal.SetDescription(description);
                    sGoal.SetPoints(points);
                    sGoal.SetComplete(0);
                    goals.Add(sGoal);
                }
                else if (Goaltype == 2)
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal eGoal = new EternalGoal();
                    eGoal.SetGoalType("Eternal Goal");
                    eGoal.SetName(name);
                    eGoal.SetDescription(description);
                    eGoal.SetPoints(points);
                    eGoal.SetComplete(0);
                    goals.Add(eGoal);
                }
                else
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many times would you like to complete this goal?");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    ChecklistGoal cGoal = new ChecklistGoal();
                    cGoal.SetGoalType("Checklist Goal");
                    cGoal.SetName(name);
                    cGoal.SetDescription(description);
                    cGoal.SetPoints(points);
                    cGoal.SetComplete(0);
                    cGoal.SetTimes(times);
                    goals.Add(cGoal);
                }
            }
            //List Goals
            else if (Choice == 2)
            {
                foreach (Goal goal in goals)
                {
                    float completed = goal.IsComplete();
                    if (completed != 1)
                    {
                        Console.WriteLine($"[ ] {goal.GetName()} : {goal.GetDescription()}");
                    }
                    else
                    {
                        Console.WriteLine($"[✓] {goal.GetName()} : {goal.GetDescription()}");
                    }
                }
                Console.WriteLine(Break);
            }
            //Save Goals
            else if (Choice == 3)
            {
                Console.WriteLine(Break);
                Console.WriteLine("Please enter the filename (Ex. 'filename.txt')");
                string fileName = Console.ReadLine();
                foreach (Goal goal in goals)
                {
                    if (goal.GetGoalType() == "Simple Goal")
                    {
                        stringGoals.Add($"{goal.GetGoalType()}:{goal.GetName()}:{goal.GetDescription()}:{goal.GetPoints()}:{goal.getComplete()}");
                    }
                    else if (goal.GetGoalType() == "Eternal Goal")
                    {
                        stringGoals.Add($"{goal.GetGoalType()}:{goal.GetName()}:{goal.GetDescription()}:{goal.GetPoints()}:{goal.getComplete()}");
                    }
                    else if (goal.GetGoalType() == "Checklist Goal")
                    {
                        stringGoals.Add($"{goal.GetGoalType()}:{goal.GetName()}:{goal.GetDescription()}:{goal.GetPoints()}:{goal.getComplete()}:{goal.GetTimes()}");
                    }
                }
                System.IO.File.WriteAllLines(fileName, stringGoals);
                Console.WriteLine($"You successfully saved your entries to {fileName}");
            }
            //Load Goals
            else if (Choice == 4)
            {
                Console.WriteLine(Break);
                Console.WriteLine("Please enter the filename (Ex. 'filename.txt')");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    stringGoals.Add(line);
                }
                foreach (string index in stringGoals)
                {
                    string[] item = index.Split(":");
                    if (item[0] == "Simple Goal")
                    {
                        SimpleGoal sGoal = new SimpleGoal();
                        sGoal.SetGoalType(item[0]);
                        sGoal.SetName(item[1]);
                        sGoal.SetDescription(item[2]);
                        sGoal.SetPoints(int.Parse(item[3]));
                        sGoal.SetComplete(int.Parse(item[4]));
                        goals.Add(sGoal);
                    }
                    else if (item[0] == "Eternal Goal")
                    {
                        EternalGoal eGoal = new EternalGoal();
                        eGoal.SetGoalType(item[0]);
                        eGoal.SetName(item[1]);
                        eGoal.SetDescription(item[2]);
                        eGoal.SetPoints(int.Parse(item[3]));
                        eGoal.SetComplete(int.Parse(item[4]));
                        goals.Add(eGoal);
                    }
                    else if (item[0] == "Checklist Goal")
                    {
                        ChecklistGoal cGoal = new ChecklistGoal();
                        cGoal.SetGoalType(item[0]);
                        cGoal.SetName(item[1]);
                        cGoal.SetDescription(item[2]);
                        cGoal.SetPoints(int.Parse(item[3]));
                        cGoal.SetComplete(int.Parse(item[4]));
                        cGoal.SetTimes(int.Parse(item[5]));
                        goals.Add(cGoal);
                    }
                }
                Console.WriteLine("Entries have been successfully loaded.");
            }
            //Record Event
            else if (Choice == 5)
            {
                int indexNum = 1;
                float completed =  0;
                float timesCompleted = 1;
                foreach (Goal goal in goals)
                {
                    completed = goal.IsComplete();
                    
                    if (completed != 1)
                    {
                        string goalType = goal.GetGoalType();
                        if (goalType == "Checklist Goal")
                        {
                            Console.WriteLine($"{indexNum}. [ ] {goal.GetName()} : {goal.GetDescription()} [{completed}]");
                        }
                        else
                        {
                            Console.WriteLine($"{indexNum}. [ ] {goal.GetName()} : {goal.GetDescription()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{indexNum}. [✓] {goal.GetName()} : {goal.GetDescription()}");
                    }
                    indexNum += 1;
                }
                Console.WriteLine(Break);
                Console.WriteLine("Which goal did you acomplish?");
                int completedGoal = int.Parse(Console.ReadLine()) - 1;
                if (goals[completedGoal].GetGoalType() == "Checklist Goal")
                {
                    float pastTimes = goals[completedGoal].getComplete();
                    timesCompleted += pastTimes;
                }
                else
                {
                    timesCompleted = 1;
                }
                goals[completedGoal].SetComplete(timesCompleted);
                totalPoints += goals[completedGoal].GetPoints();
                Console.WriteLine($"Congrats on completing your goal of: {goals[completedGoal].GetName()}!");
                Console.WriteLine(Break);
                
            }
            else
            {
                Console.WriteLine("Hope you have a great day!");
                Console.Clear();
            }
        }
    }
}