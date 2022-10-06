using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Hashtable table = new Hashtable();
            for(int cnt = 0; cnt < s.Length;cnt++)
            {
                if (table.Contains(s[cnt]))
                {
                    if ((char)table[s[cnt]] != t[cnt])
                    {
                        return false;
                    }
                }
                else
                {
                    if (table.ContainsValue(t[cnt]))
                    {
                        return false;
                    }

                    table.Add(s[cnt], t[cnt]);
                }
            }

            return true;
        }
    }
}
