using System;
using System.Collections;
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
            int ret = 1;
            List<int> endtime = new List<int>();

            if (intervals.Length == 1)
            {
                return ret;
            }

            Array.Sort(intervals, this.Compare);
            for (int cnt = 0; cnt < intervals.Length; cnt++)
            {
                if (cnt == 0)
                {
                    endtime.Add(intervals[cnt][1]);
                    continue;
                }

                var lastEndTime = endtime.Take(1).First();
                if (intervals[cnt][0] < lastEndTime)
                {
                    ret++;
                }
                else
                {
                    endtime.Remove(lastEndTime);
                }

                endtime.Add(intervals[cnt][1]);
                endtime.Sort();
            }


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
