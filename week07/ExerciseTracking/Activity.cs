using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            _date = date;
            _lengthMinutes = lengthMinutes;
        }

        public DateTime Date => _date;
        public int LengthMinutes => _lengthMinutes;

        public abstract double GetDistance(); // Distance in miles
        public abstract double GetSpeed();    // Speed in mph
        public abstract double GetPace();     // Pace in minutes per mile

        // GetSummary method to produce a summary string
        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_lengthMinutes} min) - " +
                   $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
}}