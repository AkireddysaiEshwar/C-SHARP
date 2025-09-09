using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Function
{
    public class ConsoleApp
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new();
            for(int i = 0; i < nums.Length; i++)
            {
                // USING NESTED FOR LOOP
                // for(int j = i + 1; j < nums.Length; j++)
                // {
                //     if(nums[i] + nums[j] == target)
                //     {
                //         return new int[] { i, j };
                //     }
                // }

                int complement = target - nums[i];
                if(dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No Solution");
        }
    }
}