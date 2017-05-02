using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class StringRepeat
    {
        //Write a function called repeatStr which repeats the given string string exactly n times.
        //repeatStr(6, "I") // "IIIIII"
        //repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"
        public string repeatStr(int i, string str)
        {
            string result = "";
            for (int j = 0; j < i; j++)
            {
                result = result+str;
            }
            return result;
        }

    }
}
