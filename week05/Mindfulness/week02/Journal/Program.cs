using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter today's date (e.g., 2025-07-18): ");
                    string date = Console.ReadLine();

                    Console.Write("Enter the prompt: ");
                    string prompt = Console.ReadLine();

                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        Date = date,
                        Prompt = prompt,
                        Response = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter filename to save to (e.g., myjournal.txt): ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter filename to load from (e.g., myjournal.txt): ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
                    break;
            }
        }
    }
}
