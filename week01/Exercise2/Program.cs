using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine the base letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if they passed or not
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Better luck next time. Keep working hard!");
        }

        // Stretch Challenge: Add + or - to the grade
        int lastDigit = percentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        // F grades don't get + or -

        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}
