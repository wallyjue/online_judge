using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem_325
    {
        public int MaxSubArrayLen(int[] nums, int k)
        {
            int ret = 0;
            Hashtable table = new Hashtable();

            int[] psum = new int[nums.Length + 1];
            for (int cnt = 0; cnt <= nums.Length;cnt++)
            {
                if (cnt == 0)
                {
                    psum[cnt] = 0;
                }
                else if (cnt == 1)
                {
                    psum[cnt] = nums[0];
                }
                else
                {
                    psum[cnt] = nums[cnt - 1] + psum[cnt - 1];
                }

                if (!table.Contains(psum[cnt]))
                {
                    table.Add(psum[cnt], cnt);
                }
                if (table.Contains(psum[cnt] - k))
                {
                    ret = Math.Max(ret, cnt - (int)table[psum[cnt] - k]);
                }
            }

            return ret;
        }
    }
}
