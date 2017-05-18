using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises
{
    public class SecondHighestExercise
    {/*
         * CHALLENGE: Given an array of integers, return the second highest number.
         * For arrays of length 0 return 0, length 1 return the highest number.
         * 
         * SecondHighest([]) -> 0
         * SecondHighest([1]) -> 1
         * SecondHighest([1, 3, 5]) -> 3
         * SecondHighest([1, 3, 3]) -> 3
         * SecondHighest([1, 4, 6, 8, 23, 13]) -> 13
         */
        public int SecondHighest(int[] nums)
        {
            int highest = 0;
            //result is the second highest number
            int result = 0;
            if (nums.Length == 0)
            {
                result = 0;
            }
            if (nums.Length == 1)
            {
                result = nums[0];
            }
            if (nums.Length > 1)
            {
                if (nums[0] > nums[1])
                {
                    highest = nums[0];
                    result = nums[1];
                }
                if (nums[1] > nums[0])
                {
                    highest = nums[1];
                    result = nums[0];
                }
                for (int i = 2; i < nums.Length; i++)
                {
                    if (nums[i] >= highest)
                    {
                        result = highest;
                        highest = nums[i];
                    }
                    else if (nums[i] > result)
                    {
                        result = nums[i];
                    }
                }
            }
            return result;
        }
    }
}
