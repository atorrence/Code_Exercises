using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class Average
    {
        //Write function avg which calculates average of numbers in given list.
        public static double FindAverage(double[] array)
        {
            // Your code here
            double counter = 0;
            double sum = 0;
            if (array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                    counter++;
                }
                return sum / counter;
            }
            else
            {
                return 0;
            }
        }
    }
}

