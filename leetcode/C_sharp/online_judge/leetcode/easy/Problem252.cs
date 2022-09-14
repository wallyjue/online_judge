using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem252
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals.Length == 1)
            {
                return true;
            }

            Array.Sort(intervals, this.Compare);
            for (int cnt = 0; cnt < intervals.Length; cnt++)
            {
                if (cnt == 0)
                {
                    continue;
                }

                if (intervals[cnt][0] < intervals[cnt - 1][1])
                {
                    return false;
                }

            }

            return true;
        }

        private int Compare(int[] a, int[] b)
        {
            if (a[0] > b[0])
            {
                return 1;
            }
            else if (b[0] > a[0])
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
