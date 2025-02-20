using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
     public class Swimming : Activity
    {
        private int _laps;

        public Swimming(DateTime date, int lengthMinutes, int laps)
            : base(date, lengthMinutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50) / 1000.0 * 0.62; // Convert meters to miles
        }

        public override double GetSpeed()
        {
            return (GetDistance() / LengthMinutes) * 60;
        }

        public override double GetPace()
        {
            return LengthMinutes / GetDistance();
        }
    }
}