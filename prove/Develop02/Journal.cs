using System.IO;
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
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._entryText);
            }
        }

        Console.WriteLine("Entries saved to file: " + file);
    }

    public void LoadFromFile(string file)
    { }
}