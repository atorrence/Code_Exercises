using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class ExesAndOhs
    {
        //Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. The string can contains any char.

        // Examples input/output:

        //XO("ooxx") => true
        //XO("xooxx") => false
        //XO("ooxXm") => true
        //XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
        //XO("zzoo") => false

        public bool DoesXEqualO(string str)
        {
            int xCount = 0;
            int oCount = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1).ToUpper() == "X")
                {
                    xCount++;
                }
                if (str.Substring(i, 1).ToUpper() == "O")
                {
                    oCount++;
                }
            }
            if (xCount == oCount)
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
