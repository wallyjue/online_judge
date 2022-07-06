using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem213
    {
        // dynamic function

        // f(n) = Math.Max( f(n-1), nums[n-2] + f(n-2));

        Hashtable table = new Hashtable();
        public int Rob(int[] nums)
        {
            int[] robbedMax = new int[nums.Length + 1];
            robbedMax[0] = 0;
            robbedMax[1] = nums[0];
            robbedMax[2] = Math.Max(nums[0], nums[1]);
            robbedMax[3] = Math.Max(robbedMax[2], nums[2]);

            for (int cnt = 4; cnt < nums.Length + 1; cnt++)
            {
                robbedMax[cnt] = Math.Max(robbedMax[cnt - 2] + nums[cnt - 2], robbedMax[cnt - 1]);
            }

            return robbedMax[nums.Length];
        }
    }
}
