using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
       foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(String filename)
    {
       List<string> lines = new List<string>();
            foreach (Entry entry in _entries)
            {
                lines.Add($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
            File.WriteAllLines(filename, lines);
    }

    public void LoadFromFile(String filename)
    {
      string[] lines = File.ReadAllLines(filename);

      _entries.Clear();

      foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(date, prompt, response);


            AddEntry(entry);

        }
    }
}