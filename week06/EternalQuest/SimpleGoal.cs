using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
   public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, int points) : base(goalName, points) { }

    public override void CompleteGoal()
    {
        Console.WriteLine($"{GoalName} completed! Earned {Points} points.");
    }
}

}