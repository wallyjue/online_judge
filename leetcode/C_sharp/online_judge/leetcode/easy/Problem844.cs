using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem844
    {
        public bool BackspaceCompare(string s, string t)
        {
            StringBuilder sb1 = new StringBuilder();
            for (int cnt = 0; cnt < s.Length ;cnt++)
            {
                if (s[cnt] != '#')
                {
                    sb1.Append(s[cnt]);
                }
                else if (sb1.Length > 0)
                {
                    sb1.Remove(sb1.Length - 1, 1);
                }
            }

            StringBuilder sb2 = new StringBuilder();
            for (int cnt = 0; cnt < t.Length; cnt++)
            {
                if (t[cnt] != '#')
                {
                    sb2.Append(t[cnt]);
                }
                else if (sb2.Length > 0)
                {
                    sb2.Remove(sb2.Length - 1, 1);
                }
            }

            return sb1.ToString() == sb2.ToString();
        }
    }
}
