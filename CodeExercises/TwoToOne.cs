using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class TwoToOne
    {
        //Take 2 strings s1 and s2 including only letters from a to z.Return a new sorted string, 
        //the longest possible, containing distinct letters,
        public static string Longest(string s1, string s2)
        {
            string str = s1 + s2;
            char[] distinctCharacters = (str.Distinct().ToArray());
            Array.Sort(distinctCharacters);
            return new String(distinctCharacters);
        }
    }
}

