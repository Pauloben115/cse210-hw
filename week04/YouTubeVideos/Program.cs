using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Cook Pasta", "Chef Emma", 300);
        video1.AddComment(new Comment("Alice", "Looks delicious!"));
        video1.AddComment(new Comment("Bob", "Tried it and loved it."));
        video1.AddComment(new Comment("Charlie", "Please share more recipes!"));

        Video video2 = new Video("C# Basics Tutorial", "Dev John", 900);
        video2.AddComment(new Comment("Sophie", "Super helpful."));
        video2.AddComment(new Comment("Tom", "Great explanation."));
        video2.AddComment(new Comment("Rachel", "Please do LINQ next."));

        Video video3 = new Video("DIY Organizer", "CraftyCat", 450);
        video3.AddComment(new Comment("Mark", "Made it for my desk."));
        video3.AddComment(new Comment("Lucy", "So creative!"));
        video3.AddComment(new Comment("Nina", "Easy to follow."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
