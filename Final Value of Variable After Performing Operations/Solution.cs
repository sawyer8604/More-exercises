using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Value_of_Variable_After_Performing_Operations
{
    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "--X" || operations[i] == "X--")
                {
                    result--;
                }
                else
                {
                    result++;
                }
            }

            return result;
        }

    }
}
