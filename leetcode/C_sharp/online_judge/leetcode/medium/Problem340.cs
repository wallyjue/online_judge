using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem340
    {
        public int LengthOfLongestSubstringKDistinct(string s, int k)
        {
            if (k == 0)
            {
                return 0;
            }

            int ret = 0;
            int left = 0, right = 0, temp = 0;
            Hashtable table = new Hashtable();
            for(right = 0; right < s.Length; right++)
            {
                if (!table.ContainsKey(s[right]))
                {
                    table.Add(s[right], 1);
                    temp++;
                }
                else
                {
                    table[s[right]] = (int)table[s[right]] + 1;
                }

                while(temp > k)
                {
                    if (table.ContainsKey(s[left]))
                    {
                        if ((int)table[s[left]] == 1)
                        {
                            table.Remove(s[left]);
                            temp--;
                        }
                        else
                        {
                            table[s[left]] = (int)table[s[left]] - 1;
                        }
                    }
                    left++;
                }

                ret = Math.Max(ret, right - left + 1);
            }


            return ret;
        }
    }
}
