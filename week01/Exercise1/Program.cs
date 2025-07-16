using System;

class Program
{
    static void Main()
    {
        // Ask for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Output in the specified format
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
