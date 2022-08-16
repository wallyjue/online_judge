using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem1004
    {
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, right = 0;
            int max = 0;
            int zeros = 0;
            for(right = 0; right < nums.Length;right++)
            {
                if (nums[right] == 0)
                {
                    zeros++;

                    while (zeros > k)
                    {
                        if (nums[left++] == 0)
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
