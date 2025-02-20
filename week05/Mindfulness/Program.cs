using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing", 0 },
            { "Reflection", 0 },
            { "Listing", 0 }
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            if (choice == "4") break;

            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activityLog["Breathing"]++;
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activityLog["Reflection"]++;
                    break;
                case "3":
                    activity = new ListingActivity();
                    activityLog["Listing"]++;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Thread.Sleep(1000);
                    continue;
            }

            activity.Run();
        }

      
        Console.Clear();
        Console.WriteLine("Activity Log:");
        foreach (var entry in activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Console.WriteLine("Thank you for using the Mindfulness App!");
    }
}