using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem56
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> draft = new List<int[]>();
            Array.Sort(intervals, this.Compare);

            int lastUpper = intervals[0][1];
            int lastLower = intervals[0][0];
            for(int cnt = 0; cnt < intervals.Length; cnt++)
            {
                if (intervals[cnt][0] <= lastUpper)
                {   
                    lastUpper = intervals[cnt][1] > lastUpper ? intervals[cnt][1] : lastUpper;
                    lastLower = intervals[cnt][0] < lastLower ? intervals[cnt][0] : lastLower;
                }
                else
                {
                    int[] data = new int[2];
                    data[0] = lastLower;
                    data[1] = lastUpper;
                    draft.Add(data);

                    lastUpper = intervals[cnt][1];
                    lastLower = intervals[cnt][0];
                }

                if (cnt == intervals.Length - 1)
                {
                    int[] data = new int[2];
                    data[0] = lastLower;
                    data[1] = lastUpper;
                    draft.Add(data);
                }
            }

            return draft.ToArray();
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
