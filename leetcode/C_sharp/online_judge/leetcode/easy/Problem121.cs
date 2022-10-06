using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem121
    {
        // dynamic function
        // dp(n) = max( dp(n-1), nums[n] - cost);
        
        public int MaxProfit(int[] prices)
        {
            int cost = 0;
            int[] dp = new int[prices.Length];
            int ret = 0;
            dp[0] = 0;
            cost = prices[0];

            for (int cnt = 1; cnt < prices.Length;cnt++)
            {
                cost = Math.Min(cost, prices[cnt]);
                dp[cnt] = Math.Max(dp[cnt - 1], prices[cnt] - cost);
                ret = dp[cnt];
            }

            return ret;
        }
    }
}
