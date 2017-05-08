using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class LateArrival
    {
        /*
         * A modern approach to two trains leave the station at the time....Late Arrival informs 
         * us if we will be late our destination by using the expected arrival time, our distance
         * remaining and our current rate of travel.
         * 
         * LateArrival(20, 10, 60) - true
         * LateArrival(20, 20, 60) - true
         * LateArrival(40, 60, 50) - false
         */
        public bool IsLateArrival(int minutesTilExpectedArrival, int milesRemaining, int mph)
        {
            double milesPerMinute = mph * 1 / 60;
            if (milesRemaining / milesPerMinute <= minutesTilExpectedArrival)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
