using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

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
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Date~Prompt~Entry");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entryText}");
            }
        }

        Console.WriteLine($"Entries succesfully saved to {filename}");
    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(filename);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("~");

                Entry entry = new Entry()
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _entryText = parts[2],
                };

                _entries.Add(entry);
            }

            Console.WriteLine($"The entries from {filename} have been loaded");
        }

        else
        {
            Console.WriteLine($"Sorry, {filename} was not found in the current folder");
        }
    }
}