using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem300
    {
        // dynamic function
        
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                dp[cnt] = 1;
            }

            for (int x = 1; x < nums.Length;x++)
            {
                for (int y = 0; y < x; y++)
                {
                    if (nums[x] > nums[y])
                    {
                        dp[x] = Math.Max(dp[x], dp[y] + 1);
                    }
                }
            }

            int max = int.MinValue;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                max = Math.Max(max, dp[cnt]);
            }

            return max;
        }
    }
}
