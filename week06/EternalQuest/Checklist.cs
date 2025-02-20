using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletionCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string goalName, int points, int targetCount, int bonusPoints)
        : base(goalName, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CompletionCount = 0;
    }

    public override void TrackProgress()
    {
        CompletionCount++;
        Points += 100; 
        Console.WriteLine($"You have completed {CompletionCount}/{TargetCount} for {GoalName}. Total Points: {Points}");
        
        if (CompletionCount == TargetCount)
        {
            CompleteGoal(); 
        }
    }

    public override void CompleteGoal()
    {
        Points += BonusPoints;
        Console.WriteLine($"Goal Completed! You get {BonusPoints} bonus points! Total Points: {Points}");
    }
}

}