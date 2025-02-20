using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        ShowCountdown(5);

        List<string> items = new List<string>();
        int elapsed = 5;
        while (elapsed < Duration)
        {
            Console.Write("Enter an item: ");
            items.Add(Console.ReadLine());
            elapsed += 5;
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}