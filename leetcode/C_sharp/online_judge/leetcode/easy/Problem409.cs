using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem409
    {
        public int LongestPalindrome(string s)
        {
            int ret = 0;
            Hashtable map = new Hashtable();
            for (int cnt = 0; cnt < s.Length;cnt++)
            {
                if (map.ContainsKey(s[cnt]))
                {
                    ret++;
                    map.Remove(s[cnt]);
                    if (map.Count > 0)
                    {
                        ret++;
                    }
                }
                else
                {
                    if (ret % 2 == 0)
                    {
                        ret++;
                    }
                    map.Add(s[cnt], true);
                }

            }

            return ret;
        }
    }
}
