using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
  public abstract class Goal
{
    public string GoalName { get; set; }
    public int Points { get; set; }

    public Goal(string goalName, int points)
    {
        GoalName = goalName;
        Points = points;
    }

    public virtual void TrackProgress() 
    {
        Console.WriteLine($"{GoalName}: Tracking progress...");
    }

    public abstract void CompleteGoal();

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{GoalName} - {Points} points");
    }
}
}