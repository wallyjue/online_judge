using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem485
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int ret = 0, temp = 0;
            for(int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (nums[cnt] == 1)
                {
                    ret = Math.Max(ret, ++temp);
                }
                else
                {
                    temp = 0;
                }
            }
            return ret;
        }
    }
}
