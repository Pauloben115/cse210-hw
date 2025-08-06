using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        PauseWithAnimation(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        PauseWithAnimation(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        PauseWithAnimation(3);
    }

    public void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void Start()
    {
        DisplayStartingMessage();
        Run();
        DisplayEndingMessage();
    }

    public virtual void Run()
    {
        // Empty - to be overridden
    }
}
