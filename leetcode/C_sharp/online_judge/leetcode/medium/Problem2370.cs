using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem2370
    {
        public int LongestIdealString(string s, int k)
        {
            int lastAddedchar = 0;
            string sub = string.Empty;
            for(int cnt = 0; cnt < s.Length; cnt++)
            {
                if (lastAddedchar == 0 || Math.Abs(s[cnt] - lastAddedchar) <= k)
                {
                    lastAddedchar = s[cnt];
                    sub += s[cnt];
                }
            }

            return sub.Length;
        }
    }
}
