using System;
using System.Collections.Generic;
using System.Text;

namespace Concatenation_of_Array
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] array = new int[nums.Length * 2];

            int n = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                array[i] = nums[i];
                array[i + n] = nums[i];
            }

            return array;
        }

    }
}
