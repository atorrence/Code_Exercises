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
            string answer = new string(str.Distinct().ToArray());
            //Why is answer a string, but we cast it toArray?
            char[] c = answer.ToCharArray();
            Array.Sort(c);
            return new String(c);
            
            // your code
            //string str = s1 + s2;
            ////string answer = new String(str.Distinct().ToArray());
            //char[] result = str.ToArray();
            ////result.Distinct();
            //Array.Sort(result);
            //string r = string.Concat(result);
            ////string answer = (result.Distinct());
            ////string r = string.Concat(result);
            //return sS;
        }
    }
}

