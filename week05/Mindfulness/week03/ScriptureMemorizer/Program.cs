using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = LoadRandomScripture("scriptures.txt");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // You can increase this number for difficulty
        }

        Console.Clear();
        Console.WriteLine("Final Scripture:");
        Console.WriteLine(scripture.GetDisplayText());
    }

    static Scripture LoadRandomScripture(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split('|');
            if (parts.Length < 5) continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verseStart = int.Parse(parts[2]);
            string verseEndStr = parts[3];
            string text = parts[4];

            Reference reference;
            if (string.IsNullOrWhiteSpace(verseEndStr))
            {
                reference = new Reference(book, chapter, verseStart);
            }
            else
            {
                int verseEnd = int.Parse(verseEndStr);
                reference = new Reference(book, chapter, verseStart, verseEnd);
            }

            scriptures.Add(new Scripture(reference, text));
        }

        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        return scriptures[index];
    }
}
