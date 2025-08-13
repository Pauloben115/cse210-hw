using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEternal Quest Goal Tracker");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetName()}");
        }

        int choice = int.Parse(Console.ReadLine());

        if (choice < 1 || choice > goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        int earnedPoints = goals[choice - 1].RecordEvent();
        totalScore += earnedPoints;

        Console.WriteLine($"Event recorded! You earned {earnedPoints} points.");
    }

    static void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.GetName()} - {goal.GetDescription()}");
        }
    }
}
