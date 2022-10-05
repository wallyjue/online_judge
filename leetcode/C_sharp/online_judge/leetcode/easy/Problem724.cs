using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem724
    {
        public int PivotIndex(int[] nums)
        {
            int ret = -1;
            int sum = 0;
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                sum += nums[cnt];
            }

            int temp = 0;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (cnt > 0)
                {
                    temp += nums[cnt - 1];
                }
                
                if (sum == nums[cnt] + temp * 2)
                {
                    return cnt;
                }
            }

            return ret;
        }
    }
}
