using System;
using ExerciseTracking;

class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2023, 10, 1), 30, 3.0),
                new Cycling(new DateTime(2023, 10, 2), 45, 15.0),
                new Swimming(new DateTime(2023, 10, 3), 60, 40)
            };

            // Display summaries
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
