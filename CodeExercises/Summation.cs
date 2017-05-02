using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class Summation
    {
        public static int summation(int num)
        {
            //Code here
            int sum = 0;
            for(int i = 1; i <= num; i++)
            {
                sum += i;
            }
                return sum;
        }
    }
}
