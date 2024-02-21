using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("How to C#", "Jane Doe", 300);
        video1.AddComment("John Smith", "Great video!");
        video1.AddComment("Alice Johnson", "Very helpful, thanks!");

        DisplayVideoInfo(video1);
    }

    static void DisplayVideoInfo(Video video)
    {
        Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.Length} seconds");
        Console.WriteLine("Comments:");

        foreach (var comment in video.GetComments())
        {
            comment.Display();
        }
    }
}
