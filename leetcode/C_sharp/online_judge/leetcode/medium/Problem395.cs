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
            int max = 0;
            Hashtable table = new Hashtable();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (table.Contains(s[cnt]))
                {
                    int count = (int)table[s[cnt]];
                    table.Remove(s[cnt]);
                    table.Add(s[cnt], count + 1);
                }
                else
                {
                    table.Add(s[cnt], 1);
                }
            }
            string sub = string.Empty;
            Dictionary<char,int> substring = new Dictionary<char, int>();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if ((int)table[s[cnt]] >= k)
                {
                    sub += s[cnt];
                    if (!substring.ContainsKey(s[cnt]))
                    {
                        substring.Add(s[cnt], 1);
                    }
                    else
                    {
                        int count = (int)substring[s[cnt]];
                        substring.Remove(s[cnt]);
                        substring.Add(s[cnt], count + 1);
                    }

                    bool isValid = true;
                    foreach(var alpha in substring)
                    {
                        if (alpha.Value < k)
                        {
                            isValid = false;
                        }
                    }

                    if (isValid)
                    {
                        max = Math.Max(max, sub.Length);
                    }
                    
                }
                else
                {
                    substring = new Dictionary<char, int>();
                    sub = string.Empty;
                }
            }

            return max;
        }
    }
}
