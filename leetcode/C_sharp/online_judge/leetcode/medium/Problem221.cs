using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace online_judge.leetcode.medium
{
    internal class Problem221
    {
        // need to do it again
        int[][] dp;
        public int MaximalSquare(char[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            dp = new int[m + 1][];
            for (int cnt = 0; cnt <= m;cnt++)
            {
                dp[cnt] = new int[n + 1]; 
            }
            int maxside = int.MinValue;

            for (int cnt = 1; cnt <= m;cnt++)
            {
                for(int cnt2 = 1; cnt2 <= n;cnt2++)
                {
                    if (matrix[cnt - 1][cnt2 - 1] == '1')
                    {
                        dp[cnt][cnt2] = Math.Min(Math.Min(dp[cnt - 1][cnt2 - 1], dp[cnt - 1][cnt2]), dp[cnt][cnt2 - 1]) + 1;
                        maxside = Math.Max(maxside, dp[cnt][cnt2]);
                    }
                }
            }

            return maxside * maxside;
        }
    }
}
