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

        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            int[] list1 = nums.SkipLast(1).ToArray();
            int[] list2 = nums.Skip(1).ToArray();
            int t1 = Rob_(list1);
            int t2 = Rob_(list2);

            return Math.Max(t1, t2);
        }


        public int Rob_(int[] nums)
        {
            int[] robbedMax = new int[nums.Length + 1];
            robbedMax[0] = 0;
            robbedMax[1] = nums[0];

            for (int cnt = 2; cnt < nums.Length + 1; cnt++)
            {
                robbedMax[cnt] = Math.Max(robbedMax[cnt - 2] + nums[cnt - 1], robbedMax[cnt - 1]);
            }

            return robbedMax[nums.Length];
        }
    }
}
