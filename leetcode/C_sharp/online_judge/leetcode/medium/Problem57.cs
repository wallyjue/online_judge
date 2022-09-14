using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem57
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> draft = new List<int[]>();
            var list = intervals.ToList();
            list.Add(newInterval);
            list.Sort(this.Compare);

            int lastUpper = list[0][1];
            int lastLower = list[0][0];
            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                if (list[cnt][0] <= lastUpper)
                {
                    lastUpper = list[cnt][1] > lastUpper ? list[cnt][1] : lastUpper;
                    lastLower = list[cnt][0] < lastLower ? list[cnt][0] : lastLower;
                }
                else
                {
                    int[] data = new int[2];
                    data[0] = lastLower;
                    data[1] = lastUpper;
                    draft.Add(data);

                    lastUpper = list[cnt][1];
                    lastLower = list[cnt][0];
                }

                if (cnt == list.Count - 1)
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
