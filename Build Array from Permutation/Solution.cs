using System;
using System.Collections.Generic;
using System.Text;

namespace Build_Array_from_Permutation
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] array = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                array[i] = nums[nums[i]];
            }

            return array;
        }
    }
}
