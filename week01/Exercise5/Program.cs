using System;

class Program
{
<<<<<<< HEAD
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    }
}
=======
    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        // We should validate input here
        while (true)
        {
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int number);
            if (success)
            {
                return number;
            }
            Console.Write("Invalid number. Please enter a valid integer: ");
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
>>>>>>> 3f1b8e6c3da401a32a948938b367eaf6e1dcfbc4
