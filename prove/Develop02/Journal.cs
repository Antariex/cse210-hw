using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Prompts prompts = new Prompts();
        string randomPrompt = prompts.RandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.Write("> ");
        string userEntry = Console.ReadLine();
        newEntry._entryText = userEntry;
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        Console.WriteLine("All Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry._entryText);
        }

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    { }
}