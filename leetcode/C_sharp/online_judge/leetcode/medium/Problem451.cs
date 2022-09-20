using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem451
    {
        public string FrequencySort(string s)
        {
            StringBuilder sb = new StringBuilder(string.Empty, s.Length);
            PriorityQueue<char, int> pq = new PriorityQueue<char, int>(Comparer<int>.Create((x, y) => y - x));
            int[] table = new int[128];
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                table[s[cnt]]++;
            }

            for(int index = 0;index < 128;index++)
            {
                if (table[index] > 0)
                {
                    pq.Enqueue((char)index, table[index]);
                }
            }

            while(pq.Count > 0)
            {
                char element;
                int times;
                pq.TryDequeue(out element, out times);
                sb.Append(element, times);
            }

            return sb.ToString();
        }
    }
}
