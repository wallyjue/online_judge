using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.mockup
{
    internal class Test2
    {
        public string[] UncommonFromSentences(string s1, string s2)
        {
            Dictionary<string, int> once = new Dictionary<string, int>();

            List<string> ret = new List<string>();
            foreach( string s in s1.Split(' '))
            {
                if (once.ContainsKey(s))
                {
                    var item = once[s];
                    once.Remove(s);
                    once.Add(s, item + 1);
                }
                else
                {
                    once.Add(s, 1);
                }
            }
            foreach (string s in s2.Split(' '))
            {
                if (once.ContainsKey(s))
                {
                    var item = once[s];
                    once.Remove(s);
                    once.Add(s, item + 1);
                }
                else
                {
                    once.Add(s, 1);
                }
            }

            foreach(var item in once)
            {
                if (item.Value == 1)
                {
                    ret.Add(item.Key);
                }
            }

            return ret.ToArray();
        }

        public int MaxNumberOfApples(int[] weight)
        {
            Array.Sort(weight);
            int ret = 0;
            int weights = 0;
            for(int cnt = 0; cnt < weight.Length;cnt++)
            {
                weights += weight[cnt];

                if (weights <= 5000)
                {
                    ret++;
                }
                else
                {
                    ret--;
                    break;
                }
            }
            
            return ret;
        }
    }
}
