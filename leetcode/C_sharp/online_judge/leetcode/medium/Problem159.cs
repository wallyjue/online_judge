using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem159
    {
        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            int max = int.MinValue;
            int left = 0, right = 0;
            Hashtable table = new Hashtable();
            for(right = 0; right < s.Length;right++)
            {
                if (!table.ContainsKey(s[right]))
                {
                    table.Add(s[right], 1);
                }
                else
                {
                    int count = (int)table[s[right]];
                    table.Remove(s[right]);
                    table.Add(s[right], ++count);
                }

                while (table.Count > 2)
                {
                    int count = (int)table[s[left]];
                    if (count > 1)
                    {
                        table.Remove(s[left]);
                        table.Add(s[left++], --count);
                    }
                    else
                    {
                        table.Remove(s[left++]);
                    }
                }

                max = Math.Max(max, right - left + 1);
            }

            return max;
        }
    }
}
