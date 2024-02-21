using System;
using System.Text;

public class Comment
{
    public string Name { get; }
    public string Text { get; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public void Display()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{Name} says: \"{Text}\"");
        Console.WriteLine(sb.ToString());
    }
}
