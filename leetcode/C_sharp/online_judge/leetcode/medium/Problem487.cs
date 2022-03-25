using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem487
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int longestSequence = 0;
            int left = 0;
            int right = 0;
            int numZeroes = 0;

            // while our window is in bounds
            while (right < nums.Length)
            {

                // add the right most element into our window
                if (nums[right] == 0)
                {
                    numZeroes++;
                }

                // if our window is invalid, contract our window
                while (numZeroes == 2)
                {
                    if (nums[left] == 0)
                    {
                        numZeroes--;
                    }
                    left++;
                }

                // update our longest sequence answer
                longestSequence = Math.Max(longestSequence, right - left + 1);

                // expand our window
                right++;
            }
            return longestSequence;
        }

        // private int GetConsecutiveOnes(int[] nums, int )
    }
}
