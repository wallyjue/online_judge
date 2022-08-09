using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem2316
    {
        public long CountPairs(int n, int[][] edges)
        {
            long ret = 0;
            HashSet<int>[] nodes = new HashSet<int>[n];
            foreach (int[] edge in edges)
            {
                nodes[edge[0]].Add(edge[1]);
                nodes[edge[1]].Add(edge[0]);
            }

            for (int cnt = 0; cnt < nodes.Length;cnt++)
            {
                ret += visiting(nodes, cnt);
            }

            return ret;
        }

        private int visiting(HashSet<int>[] nodes, int start)
        {
            int ret = 0;
            Hashtable visited = new Hashtable();
            visited.Add(start, true);
            for (int cnt = 0; cnt < nodes[start].Count;cnt++)
            {
                if (cnt == start)
                {
                    continue;
                }
            }

            return ret;
        }
    }
}
