using System;

public class Entry
{
    public required string Date { get; set; }
    public required string Prompt { get; set; }
    public required string Response { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    public static Entry FromString(string line)
    {
        var parts = line.Split('|');
        if (parts.Length != 3)
            throw new FormatException("Invalid entry format.");

        return new Entry
        {
            Date = parts[0],
            Prompt = parts[1],
            Response = parts[2]
        };
    }

    public override string ToString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }
}
