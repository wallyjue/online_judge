using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem557
    {
        public string ReverseWords(string s)
        {
            string ret = string.Empty;
            var words = s.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    ret = ReverseString(words[i].ToCharArray());
                }
                else
                {
                    ret += $" {ReverseString(words[i].ToCharArray())}";
                }
            }

            return ret;
        }

        public string ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            string ret = string.Empty;
            foreach (char c in s)
            {
                ret += $"{c}";
            }
            return ret;
        }
    }
}
