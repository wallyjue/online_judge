using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem438
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            int[] table = new int[26];
            int[] ptable = new int[26];

            List<int> ans = new List<int>();
            if (p.Length > s.Length) return ans;


            int left = 0, right = 0;

            for (right = 0; right < p.Length; right++)
            {
                ptable[p[right] - 97]++;
            }

            for (right = 0; right < p.Length;right++)
            {
                table[s[right] - 97]++;
            }
            right--;
            for (left = 0; right < s.Length;left++, right++)
            {
                bool isAnagram = true;
                for (int cnt = 0; cnt < 26;cnt++)
                {
                    if (ptable[cnt] != table[cnt])
                    {
                        isAnagram = false;
                        break;
                    }
                }

                if (isAnagram) ans.Add(left);

                if (right + 1 == s.Length) break;

                table[s[left] - 97]--;
                table[s[right + 1] - 97]++;
            }

            return ans;
        }
    }
}
