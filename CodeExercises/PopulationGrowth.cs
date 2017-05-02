using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class PopulationGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            //p0 = beginning population
            //aug is the number of increase each year
            //p is the pop number to reach
            // y is number of years to reach new pop
            int y = 0;
            double newP0 = 0;
            newP0 = p0;
            while (newP0 < p)
            {
                newP0 = newP0 + newP0 * (percent / 100) + aug;
                y++;
            }
            return y;
        }
    }
}
