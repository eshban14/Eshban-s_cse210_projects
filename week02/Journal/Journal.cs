using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<JournalEntry> entries = new List<JournalEntry>();
        private List <string> prompts = new List<string>
        {
            "Who was the most interesting person I met today?",
            "What was the best part of your day?",
            "How did I see the hand of the Jesus Christ in my life today?",
            "What was the strongest emotion i felt today?",
            "If i had one thing to do over today, what would it be?"

        };

        public void AddEntry(){
            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your Response: ");
            string response = Console.ReadLine();

            JournalEntry entry = new JournalEntry(prompt, response);
            entries.Add(entry);
            Console.WriteLine("Entry added successfully!");
        }
        public void DisplayEntries(){
            if (entries.Count == 0){
                Console.WriteLine("No entries to display.");
                return;
            }
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        public void SaveToFile(string filename){
            using (StreamWriter writer = new StreamWriter(filename)){
                foreach (var entry in entries){
                    writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully");
        }

        public void LoadFromFile(string filename){
            if (!File.Exists(filename)){
                Console.WriteLine("FIle not found!");
                return;
            }

            entries.Clear();

            foreach (var Line in File.ReadLines(filename))
            {
                string[] parts = Line.Split("~|~");
                if (parts.Length == 3)
                {
                    JournalEntry entry = new JournalEntry(parts[1], parts[2]) {Date = parts[0]};
                    entries.Add(entry);
                }
            }
            
            Console.WriteLine("Journal Loaded successfully");

        }

    }
}