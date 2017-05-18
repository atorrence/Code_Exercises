using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class Dubstep
    {
        //Instructions
        //Let's assume that a song consists of some number of words.     
        //To make the dubstep remix of this song, Polycarpus inserts a certain number of words "WUB" 
        //before the first word of the song (the number may be zero), after the last
        //word (the number may be zero), and between words (at least one between 
        //any pair of neighbouring words), and then the boy glues together all the 
        //words, including "WUB", in one string and plays the song at the club.

        //Input
        //The input consists of a single non-empty string, consisting only of uppercase English letters, 
        //the string's length doesn't exceed 200 characters
        //Output
        //Return the words of the initial song that Polycarpus used to make a dubsteb remix.
        //Separate the words with a space.
        //Examples
        //songDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"
        // =>  WE ARE THE CHAMPIONS MY FRIEND
        public string SongDecoder(string input)
        {
            // Your code...
            //string[] inputArray = input.Split();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (inputArray[i] == "W" && inputArray[i + 1] == "U" && inputArray[i + 2] == "B")
            //    {
            //        inputArray.Skip(3);

            //    }
            //}

            //return inputArray.ToString();
            // Assert.AreEqual("ABC", d.SongDecoder("WUBWUBABC"));

            
            
            for ( int i = 0; i < input.Length-2; i+=3)
            {
                string sub = input.Substring(i, 3);
                if (sub == "WUB")
                {
                    input = input.Substring(i + 3, input.Length-3);
                }
                
            }
            return input;
        }
    }
}