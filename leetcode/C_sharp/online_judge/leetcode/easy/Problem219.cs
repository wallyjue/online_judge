using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int left = 0, right = 0;
            bool ret = false;
            Dictionary<int, int> table = new Dictionary<int, int>();
            for(right = 0; right < nums.Length;right++)
            {
                if (right - left > k)
                {
                    table.Remove(nums[left]);
                    left++;
                }

                if (table.ContainsKey(nums[right]))
                {
                    return true;
                }
                else
                {
                    table.Add(nums[right], right);
                }
            }

            return ret;
        }
    }
}
