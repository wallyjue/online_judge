using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem763
    {
        public IList<int> PartitionLabels(string s)
        {
            List<int> ret = new List<int>();
            int[] leftbound = new int[26], rightbound = new int [26];
            for (int cnt = 0; cnt < 26; cnt++)
            {
                leftbound[cnt] = -1;
                rightbound[cnt] = -1;
            }

            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (leftbound[s[cnt] - 97] == -1)
                {
                    leftbound[s[cnt] - 97] = cnt;
                }
                rightbound[s[cnt] - 97] = cnt;
            }

            int bounce = 0;
            int start = 0;
            Hashtable table = new Hashtable();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (bounce == 0)
                {
                    start = cnt;
                }

                for (int alpha = 0; alpha < 26; alpha++)
                {
                    if (leftbound[alpha] == -1 || rightbound[alpha] == -1)
                    {
                        continue;
                    }

                    if (cnt < leftbound[alpha] || cnt > rightbound[alpha])
                    {
                        continue;
                    }

                    if (!table.Contains((char)(alpha + 97)) && leftbound[alpha] != -1 && cnt >= leftbound[alpha])
                    {
                        bounce++;
                        table.Add((char)(alpha+97), cnt);
                    }

                    if (rightbound[alpha] != -1 && cnt >= rightbound[alpha])
                    {
                        bounce--;
                        table.Remove((char)(alpha + 97));
                    }
                }

                if (bounce == 0)
                {
                    ret.Add(cnt - start + 1);
                    start = 0;
                }
            }
            return ret;
        }
    }
}
