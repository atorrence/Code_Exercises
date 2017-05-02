using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class ReversingWords
    {
        //You need to write a function that reverses the words in a given string. A word can also fit an empty string. If this is not clear enough, here are some examples:
        //Kata.Reverse("Hello World"); // -> "World Hello"
        //Kata.Reverse("Hi There."); // -> "There. Hi"

        public string reverseWords(string text)
        {
            string[] inputarray = text.Split(' ');
            string result = "";
            for (int i = inputarray.Length-1; i >= 0; i--)
            {
                if (i != inputarray.Length - 1)
                {
                    result += " ";
                }
                result += inputarray[i];
            }
            return result;
        }
    }
}
