using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (var entry in entries)
        {
            lines.Add(entry.ToString());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File '{filename}' does not exist.");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();

            foreach (var line in lines)
            {
                try
                {
                    var entry = Entry.FromString(line);
                    entries.Add(entry);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Skipping invalid entry line: {line}");
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
