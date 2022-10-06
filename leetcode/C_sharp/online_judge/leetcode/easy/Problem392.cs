using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem392
    {
        public bool IsSubsequence(string s, string t)
        {
            int tIndex = 0;

            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                tIndex = tIndex >= cnt ? tIndex : cnt;
                bool ret = false;
                for (int cnt2 = tIndex; cnt2 < t.Length; cnt2++)
                {
                    if (t[cnt2] == s[cnt])
                    {
                        ret = true;
                        tIndex = cnt2 + 1;
                        break;
                    }
                }

                if (!ret) return false;
            }

            return true;
        }
    }
}
