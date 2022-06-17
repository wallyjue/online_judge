using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];
                chars[r]++;

                while (chars[r] > 1)
                {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
        }

        public int LengthOfLongestSubstring2(string s)
        {
            int left = 0, right = 0, max = 0;
            Hashtable table = new Hashtable();
            for(right = 0; right < s.Length; right++)
            {
                if (table.Contains(s[right]))
                {
                    left = Math.Max(left, (int)table[s[right]] + 1); ;
                    table.Remove(s[right]);
                }
                table.Add(s[right], right);
                max = Math.Max(max, right - left + 1);
            }


            return max;
        }
    }
}
