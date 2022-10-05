using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem746
    {
        // dynamic function
        // f(n) = min( f(n-1), f(n-2));

        public int MinCostClimbingStairs(int[] cost)
        {
            int[] dp = new int[cost.Length];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for(int cnt = 2; cnt < cost.Length; cnt++)
            {
                dp[cnt] = Math.Min(dp[cnt-1], dp[cnt-2]) + cost[cnt];
            }

            return Math.Min(dp[cost.Length - 1], dp[cost.Length - 2]);
        }
    }
}
