using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem692
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            PriorityQueue<string, PriorityModel> pq = new PriorityQueue<string, PriorityModel>();
            Dictionary<string, int> table = new Dictionary<string, int>();
            List<string> ret = new List<string>();
            for (int cnt = 0; cnt < words.Length;cnt++)
            {
                if (table.ContainsKey(words[cnt]))
                {
                    int times = table[words[cnt]];
                    table.Remove(words[cnt]);
                    table.Add(words[cnt], ++times);
                }
                else
                {
                    table.Add(words[cnt], 1);
                }
            }

            foreach (var item in table)
            {
                pq.Enqueue(item.Key, new PriorityModel() { data = item.Key, freq = item.Value });
            }

            while(k > 0)
            {
                ret.Add(pq.Dequeue());
                k--;
            }
            
            return ret;
        }

        class TheComparer : IComparer<PriorityModel>
        {
            public int Compare(PriorityModel a, PriorityModel b)
            {
                if (a.freq > b.freq)
                {
                    return -1;
                }
                else if (a.freq < b.freq)
                {
                    return 1;
                }
                else
                {
                    return a.data.CompareTo(b.data);
                }
            }
        }

        class PriorityModel : IComparable<PriorityModel>
        {
            public string data;
            public int freq;

            public int CompareTo(PriorityModel other)
            {
                if (this.freq > other.freq)
                {
                    return -1;
                }
                else if (this.freq < other.freq)
                {
                    return 1;
                }
                else
                {
                    return this.data.CompareTo(other.data);
                }
            }
        }
    }
}
