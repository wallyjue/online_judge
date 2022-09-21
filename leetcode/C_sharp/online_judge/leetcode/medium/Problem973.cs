using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem973
    {
        public int[][] KClosest(int[][] points, int k)
        {
            int[][] ret = new int[k][];
            //PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            List<double[]> pq = new List<double[]>();
            // <index, distance>

            for (int cnt = 0; cnt < points.Length; cnt++)
            {
                double distance = Math.Sqrt(points[cnt][0] * points[cnt][0] + points[cnt][1] * points[cnt][1]);
                double[] item = new double[2] { cnt, distance};
                pq.Add(item);
            }

            pq.Sort(this.Compare);
            List<int[]> result = new List<int[]>();
            for (int cnt = 0; cnt < k;cnt++)
            {
                int[] point = points[(int)pq[cnt][0]];
                result.Add(new int[] { point[0], point[1] });
            }

            return ret;
        }

        private int Compare(double[] a, double[] b)
        {
            if (a[1] > b[1])
            {
                return 1;
            }
            else if (b[1] > a[1])
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
