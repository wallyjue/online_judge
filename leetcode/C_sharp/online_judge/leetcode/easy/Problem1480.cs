using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] ret = new int[nums.Length];
            
            for(int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (cnt > 0)
                {
                    ret[cnt] = nums[cnt] + ret[cnt - 1];
                }
                else
                {
                    ret[cnt] = nums[cnt];
                }
            }

            return ret;
        }
    }
}
