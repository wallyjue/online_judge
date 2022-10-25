using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem256
    {
        // dynamic function


        // f(n, color) = Math.Min( costs[n][color0] + Math.Min(f(n-1, color1),f(n-1, color2)),
        //                         costs[n][color1] + Math.Min(f(n-1, color0),f(n-1, color2)),
        //                         costs[n][color2] + Math.Min(f(n-1, color0),f(n-1, color1)));

        /*
         * public int MinCost(int[][] costs)
            {
                for (int n = costs.Length - 2; n >= 0; n--)
                {
                    // Total cost of painting the nth house red.
                    costs[n][0] += Math.Min(costs[n + 1][1], costs[n + 1][2]);
                    // Total cost of painting the nth house green.
                    costs[n][1] += Math.Min(costs[n + 1][0], costs[n + 1][2]);
                    // Total cost of painting the nth house blue.
                    costs[n][2] += Math.Min(costs[n + 1][0], costs[n + 1][1]);
                }

                if (costs.Length == 0) return 0;

                return Math.Min(Math.Min(costs[0][0], costs[0][1]), costs[0][2]);
            }

        */

        int[] ret;
        int[][] costs;
        public int MinCost(int[][] costs)
        {
            ret = new int[costs.Length];
            this.costs = costs;
            if (costs.Length == 1)
            {
                ret[0] = Math.Min(Math.Min(costs[0][0], costs[0][1]), costs[0][2]);
                return ret[0];
            }
            else if (costs.Length == 2)
            {
                int temp = Math.Min(costs[0][0] + Math.Min(costs[1][1], costs[1][2]), costs[0][1] + Math.Min(costs[1][0], costs[1][2]));
                ret[1] = Math.Min(temp, costs[0][2] + Math.Min(costs[1][0], costs[1][2]));
                return ret[1];
            }

            int ans = Math.Min(dpfunction(costs.Length, 2), Math.Min(dpfunction(costs.Length, 0), dpfunction(costs.Length, 1)));
            return ans;
        }

        private int dpfunction(int n, int color)
        {
            if (n == 0)
            {
                ret[0] = Math.Min(Math.Min(costs[0][0], costs[0][1]), costs[0][2]);
                return ret[0];
            }
            else if (n == 1)
            {
                int temp = Math.Min(costs[0][0] + Math.Min(costs[1][1], costs[1][2]), costs[0][1] + Math.Min(costs[1][0], costs[1][2]));
                ret[1] = Math.Min(temp, costs[0][2] + Math.Min(costs[1][0], costs[1][2]));
                return ret[1];
            }

            int min = int.MaxValue;
            for(int cnt = 0; cnt < 3;cnt++)
            {
                int color1 = (cnt + 1) % 3;
                int color2 = (cnt + 2) % 3;
                min = Math.Min(min, costs[n-1][cnt] + Math.Min(dpfunction(n - 1, color1), dpfunction(n - 1, color2)));
            }

            if (ret[n - 1] != 0)
            {
                ret[n - 1] = Math.Min(min, ret[n-1]);
            }
            else
            {
                ret[n - 1] = min;
            }
            return ret[n - 1];
        }
    }
}
