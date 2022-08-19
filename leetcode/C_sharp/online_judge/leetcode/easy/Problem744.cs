using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem744
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0, right = letters.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2 + 1;
                if (letters[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid;
                }
            }

            if (left == letters.Length - 1)
            {
                return letters[0];
            }

            if (letters[left] > target)
            {
                return letters[left];
            }
            else
            {
                return letters[left + 1];
            }
        }
    }
}
