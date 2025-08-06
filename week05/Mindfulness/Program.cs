using System;

class Program
{
    static void Main()
    {
        BreathingActivity breathing = new BreathingActivity();
        breathing.Start();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

