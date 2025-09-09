using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Function
{
    public class Solution
    {
        public bool ContainDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            for(int i = 0; i < nums.Length; i++)
            {
                if(set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
                // if(nums[i] == nums[j])
                // {
                //     return true;
                // }
            }
            return false;
        }
    }
}