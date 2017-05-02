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
            //text.Split(' ');
            //foreach (var word in text)
            //{
            //    string temp = word[0];
            //    word[length-1] = word[0];
            //}
            string[] inputarray = text.Split(' ');
            //string result = "";
            Array.Reverse(inputarray);
            //for (int i = 0; i < inputarray.Length-1; i++)
            //{
            //    result += " " + inputarray[i];
            //}
            string result = string.Join(" ", inputarray);
            return result;
        }
    }
}
