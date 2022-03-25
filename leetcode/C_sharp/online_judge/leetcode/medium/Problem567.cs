using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem567
    {
        public bool CheckInclusion(string s1, string s2)
        {
            bool ret = s1 == s2;
            int[] s1stat = new int[128];
            for (int i = 0; i < s1.Length; i++)
            {
                s1stat[s1[i]]++;
            }

            for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            {
                int[] s1statCopy = new int[128];
                s1stat.CopyTo(s1statCopy, 0);
                for (int k = i; k < s1.Length + i; k++)
                {
                    for (int j = 0; j < s1.Length; j++)
                    {
                        if (s1[j] == s2[k])
                        {
                            s1statCopy[s1[j]]--;
                            break;
                        }
                    }
                }
                ret = s1statCopy.All(x => x == 0);
                if (ret) return ret;
            }
            return ret;
        }
    }
}
