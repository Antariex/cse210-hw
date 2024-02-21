using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private readonly List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string name, string text)
    {
        comments.Add(new Comment(name, text));
    }

    public IEnumerable<Comment> GetComments()
    {
        return comments;
    }
}
