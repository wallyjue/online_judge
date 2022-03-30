using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem125
    {
        public bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                while (!IsAlphaNumeric(s[left]) && left < right)
                {
                    left++;
                }

                while (!IsAlphaNumeric(s[right]) && left < right)
                {
                    right--;
                }

                if (ToLowerCase(s[left]) != ToLowerCase(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        private bool IsAlphaNumeric(char c)
        {
            if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                return true;

            return false;
        }

        private char ToLowerCase(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                return char.ToLower(c);
            }

            return c;
        }
    }
}
