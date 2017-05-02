using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int counter = 0;
            for (int i = 0; i < sheeps.Length; i++)
            {
                if (sheeps[i] == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
