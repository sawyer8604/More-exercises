using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public class Solution
    {
        public Solution(int[] nuumbers, int targetNum)
        {
            Nuumbers = new int[nuumbers.Length];
            TargetNum = targetNum;            
        }

        public int[] Nuumbers { get; set; }
        public int TargetNum { get; set; }        

        public  int[] TwoSum(int[] nums, int targetNum)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length -1; i++)
            {                             

                int crrNum = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    int secondNum = nums[j];
                    if (crrNum + secondNum == targetNum)
                    {
                        result[0] = i;
                        result[1] = j;
                    }

                }
            }

            return result;
        }
    }
}
