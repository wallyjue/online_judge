using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem1046
    {
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(new TheComparer());
            for (int cnt = 0; cnt < stones.Length; cnt++)
            {
                pq.Enqueue(stones[cnt], stones[cnt]);
            }

            while(pq.Count > 1)
            {
                int stone1 = pq.Dequeue();
                int stone2 = pq.Dequeue();
                int result = stone1 > stone2 ? stone1 - stone2 : stone2 - stone1;
                pq.Enqueue(result, result);
            }

            return pq.Dequeue();
        }

        class TheComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x > y)
                {
                    return -1;
                }
                else if (x < y)
                {
                    return 1;
                }
                else return 0;
            }
        }
    }
}
