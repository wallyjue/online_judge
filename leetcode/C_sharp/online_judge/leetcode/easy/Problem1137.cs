using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem1137
    {
        // dynamic function
        // f(n) = f(n-3) + f(n-2) + f(n-1)
        public int Tribonacci(int n)
        {
            
            if (n <= 2)
            {
                int[] dp2 = new int[3];
                dp2[0] = 0;
                dp2[1] = 1;
                dp2[2] = 1;
                return dp2[n];
            }
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;

            for (int cnt = 3; cnt < n + 1; cnt++)
            {
                dp[cnt] = dp[cnt - 1] + dp[cnt - 2] + dp[cnt - 3];
            }

            return dp[n];
        }
    }
}
