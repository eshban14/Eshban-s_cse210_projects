using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            ShowGrowingText(3);
            elapsed += 3;

            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            ShowShrinkingText(3);
            elapsed += 3;
        }
    }

    private void ShowGrowingText(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.WriteLine(new string('*', i));
            Thread.Sleep(1000);
        }
    }

    private void ShowShrinkingText(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(new string('*', i));
            Thread.Sleep(1000);
        }
    }
}