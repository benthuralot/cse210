public class Journal
{
    List<Entry> _entries;
    
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using StreamWriter outputFile = new StreamWriter(file);
        outputFile.WriteLine("date~~prompt~~entry");
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
        }
    }
    public void LoadFromFile(string file)
    {
        Console.WriteLine("Reading from the file...");
        string[] lines = System.IO.File.ReadAllLines(file).Skip(1).ToArray();

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("~~");
                        
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}