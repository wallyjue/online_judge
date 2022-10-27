using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem265
    {
        public int MinCostII(int[][] costs)
        {
            int k = costs[0].Length;

            for (int n = costs.Length - 2; n >= 0; n--)
            {
                for (int cnt = 0; cnt < k; cnt++)
                {
                    int min = int.MaxValue;
                    for (int kcnt = 0; kcnt < k; kcnt++)
                    {
                        if (kcnt != cnt)
                        {
                            min = Math.Min(min, costs[n + 1][kcnt]);
                        }
                    }
                    costs[n][cnt] += min;
                }
            }

            if (costs.Length == 0) return 0;

            int ret = int.MaxValue;
            for (int kcnt = 0; kcnt < k;kcnt++)
            {
                ret = Math.Min(ret, costs[0][kcnt]);
            }

            return ret;
        }
    }
}
