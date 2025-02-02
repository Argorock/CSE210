using System;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Journal
    {
    // load function
    // save function
    // add entry
    // change bool
    // call entry    
        public Journal journal = new Journal();
        
        List<Entry> entries = new List<Entry>();

        public void AddEntry(PromptMan promptMan)
        {
            string prompt = PromptMan.GetRandomPrompt(promptMan.prompts);
            Entry newEntry = new Entry(prompt);
            entries.Add(newEntry);
        }

        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("There are no entries to display. ");
            }
            else
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine($"Date: {entry._date}");
                    Console.WriteLine($"Prompt: {entry._prompt}");
                    Console.WriteLine($"Entry: {entry._text}");

                }

            }
        }

        public void LoadEntries(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                entries.Clear();
                for (int i = 0; i < lines.Length; i += 3)
                {
                    DateTime date = DateTime.Parse(lines[i]);
                    string prompt = lines[i + 1];
                    string text = lines[i + 2];
                    Entry entry = new Entry(prompt);
                    Console.Write($"Date: {date} \nPrompt: {prompt} \nEntry: {text} ");


                }
            }
            else
            {
                Console.WriteLine("File not Found");
            }
        }

        public void SaveEntries(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry._date);
                    writer.WriteLine(entry._prompt);
                    writer.WriteLine(entry._text);
                }
            }
        }
    }