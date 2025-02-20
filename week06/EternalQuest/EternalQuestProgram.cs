using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class EternalQuestProgram
{
    public List<Goal> Goals = new List<Goal>();
    public int TotalPoints { get; set; } = 0;

    public void CreateGoal(Goal goal)
    {
        Goals.Add(goal);
        Console.WriteLine($"Created goal: {goal.GoalName}");
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in Goals)
        {
            if (goal.GoalName == goalName)
            {
                goal.TrackProgress();
                TotalPoints += goal.Points;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            goal.DisplayGoal();
        }
        Console.WriteLine($"Total Points: {TotalPoints}");
    }

    public void SaveProgress()
    {
        
    }

    public void LoadProgress()
    {
        
    }
}

}