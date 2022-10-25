using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem53
    {
        // Kadane's algorithm
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) return nums[0];

            int max = nums[0];
            int cur = nums[0];

            for (int cnt = 0; cnt < nums.Length ; cnt++)
            {
                cur = Math.Max(nums[cnt], cur + nums[cnt]);
                max = Math.Max(max, cur);
            }

            return max;
        }
    }
}
