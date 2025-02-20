using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
  public class EternalGoal : Goal
{
    public EternalGoal(string goalName, int points) : base(goalName, points) { }

    public override void TrackProgress()
    {
        base.TrackProgress();
        Console.WriteLine($"For {GoalName}, you get {Points} points each time.");
    }

    public override void CompleteGoal()
    {
        Console.WriteLine($"You completed {GoalName}. Points accumulated: {Points}");
    }
}

}