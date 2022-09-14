using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem253
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int ret = 0;
            Array.Sort(intervals, this.Compare);

            return ret;
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
