using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem198
    {
        // dynamic f
        // f(n) = Math.Max( f(n-1), nums[n-1] + f(n-2));
        public int Rob(int[] nums)
        {
            int[] robbedMax = new int[nums.Length + 1];
            robbedMax[0] = 0;
            robbedMax[1] = nums[0];

            for (int cnt = 2; cnt < nums.Length + 1; cnt++)
            {
                robbedMax[cnt] = Math.Max(robbedMax[cnt - 2] + nums[cnt-1], robbedMax[cnt - 1]);
            }

            return robbedMax[nums.Length];
        }
    }
}
