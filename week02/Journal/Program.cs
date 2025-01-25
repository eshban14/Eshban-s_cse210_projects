using System;
using JournalApp;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;

        do{
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal to a file");
            Console.WriteLine("4. Load the Journal to a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                journal.AddEntry();
                break;
                case "2":
                journal.DisplayEntries();
                break;
                case "3":
                Console.Write("Enter the filename to save to:");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                break;
                case "4":
                Console.WriteLine("Enter the filename to Load from: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                break;
                case "5":
                Console.WriteLine("Goodbye!");
                break;
                default:
                Console.WriteLine("Invalid choice, please try agian.");
                break;
        }
       
        } while (choice != "5");
    }
}