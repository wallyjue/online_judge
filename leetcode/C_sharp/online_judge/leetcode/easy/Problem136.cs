using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem136
    {
        public int SingleNumber(int[] nums)
        {
            int ret = 0;
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                ret ^= nums[cnt];
            }

            return ret;
        }
    }
}
