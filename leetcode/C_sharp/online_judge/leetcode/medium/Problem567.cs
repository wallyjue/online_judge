using System;
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
            bool ret = false;
            int[] s1stat = new int[128];

            for (int i = 0; i < s1.Length; i++)
            {
                s1stat[s1[i]]++;
            }

            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                int[] s1statCopy = new int[128];
                s1stat.CopyTo(s1statCopy, 0);
                for (int j = 0; j < s1.Length; j++)
                {
                    // 這邊改用 hashtable 來找 s2[i]
                    if(s1[j] == s2[i])
                    {
                        s1statCopy[s1[j]]--;
                    }
                }
                ret = s1stat.Sum() == 0;
                if (ret) return ret;
            }
            return ret;
        }
    }
}
