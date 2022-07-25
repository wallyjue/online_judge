using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem395
    {
        public int LongestSubstring(string s, int k)
        {
            int ret = 0;
            Hashtable table = new Hashtable();
            Hashtable acceptedChars = new Hashtable();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if(table.ContainsKey(s[cnt]))
                {
                    var temp = (int)table[s[cnt]];
                    table.Remove(s[cnt]);
                    table.Add(s[cnt], temp + 1);
                    if (temp+1 >= k && !acceptedChars.ContainsKey(s[cnt]))
                    {
                        acceptedChars.Add(s[cnt], true);
                    }
                }
                else
                {
                    table.Add(s[cnt], 1);
                    if (1 >= k && !acceptedChars.ContainsKey(s[cnt]))
                    {
                        acceptedChars.Add(s[cnt], true);
                    }
                }
            }

            int tmp = 0;
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if(acceptedChars.ContainsKey(s[cnt]))
                {
                    tmp++;
                }
                else
                {
                    tmp = 0;
                }

                ret = Math.Max(tmp, ret);
            }

            return ret;
        }
    }
}
