using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // A list to store all the journal entries
    private List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the list
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Displays all the entries in the journal
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Saves all entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Loads entries from a file, replacing existing entries
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear(); // Clear current list before loading new entries
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    _entries.Add(entry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    public void SearchEntries(string keyword)
    {
        foreach (Entry entry in _entries)
        {
            if (entry.Prompt.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry.Response.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                entry.Display();
            }
        }
    }
}
