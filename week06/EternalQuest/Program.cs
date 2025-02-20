using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        EternalQuestProgram program = new EternalQuestProgram();

        Goal scriptureGoal = new EternalGoal("Read Scriptures", 100);
        Goal marathonGoal = new SimpleGoal("Run Marathon", 1000);
        Goal templeGoal = new ChecklistGoal("Attend Temple", 50, 10, 500);

        program.CreateGoal(scriptureGoal);
        program.CreateGoal(marathonGoal);
        program.CreateGoal(templeGoal);

        program.RecordEvent("Read Scriptures");
        program.RecordEvent("Run Marathon");
        program.RecordEvent("Attend Temple");

        program.DisplayGoals();
    }
}