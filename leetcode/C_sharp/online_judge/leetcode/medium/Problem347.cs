using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            int[] ret = null;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            Dictionary<int, int> table = new Dictionary<int, int>();

            for(int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (table.ContainsKey(nums[cnt]))
                {
                    int count = (int)table[nums[cnt]];
                    table.Remove(nums[cnt]);
                    table.Add(nums[cnt], ++count);
                }
                else
                {
                    table.Add(nums[cnt], 1);
                }
            }

            foreach(var value in table)
            {
                pq.Enqueue(value.Key, value.Value);
            }

            List<int> theresult = new List<int>();
            for (int cnt = 0; cnt < k; cnt++)
            {
                theresult.Add(pq.Dequeue());
            }

            return ret;
        }
    }
}
