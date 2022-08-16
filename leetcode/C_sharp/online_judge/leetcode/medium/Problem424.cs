using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem424
    {
        public int CharacterReplacement(string s, int k)
        {
            int max = 0;
            int[] chars = new int[26];
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                chars[s[cnt] - 65]++;
            }

            for(int cnt = 0; cnt < chars.Length; cnt++)
            {
                if (chars[cnt] > 0)
                {
                    max = Math.Max(max, this.LongestOnes(s, (char)(cnt+65), k));
                }
            }

            return max;
        }

        private int LongestOnes(string s, char k, int limit)
        {
            int left = 0, right = 0;
            int max = 0;
            int zeros = 0;
            for (right = 0; right < s.Length; right++)
            {
                if (s[right] != k)
                {
                    zeros++;

                    while (zeros > limit)
                    {
                        if (s[left++] != k)
                        {
                            zeros--;
                        }
                    }
                }

                max = Math.Max(max, right - left + 1);
            }

            return max;
        }
    }
}
