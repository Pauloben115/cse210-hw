using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        Random randomGenerator = new Random(); // Create once outside the loop

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101); // 1 to 100
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                // Check if input is a valid number
                bool isValid = int.TryParse(input, out guess);
                if (!isValid)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue; // Skip the rest and ask again
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
