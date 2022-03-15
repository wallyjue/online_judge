using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    public class Problem977
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] ret = new int[nums.Length];
            int lcnt = 0, rcnt = nums.Length - 1;
            int cnt = nums.Length - 1;
            for (cnt = nums.Length - 1; cnt >= 0; cnt--)
            {
                int lcntAbs = nums[lcnt] >= 0 ? nums[lcnt] : -nums[lcnt];
                int rcntAbs = nums[rcnt] >= 0 ? nums[rcnt] : -nums[rcnt];
                if (lcntAbs < rcntAbs)
                {
                    ret[cnt] = rcntAbs * rcntAbs;
                    rcnt--;
                }
                else
                {
                    ret[cnt] = lcntAbs * lcntAbs;
                    lcnt++;
                }
            }
            return ret;
        }
    }
}
