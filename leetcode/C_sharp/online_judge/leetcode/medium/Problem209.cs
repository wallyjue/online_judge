﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem209
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int right = 0, left = 0;
            int min = int.MaxValue;
            int sum = 0;
            for( right = 0; right < nums.Length;right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    min = Math.Min(min, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
                
            }

            return min == int.MaxValue ? 0 : min;
        }
    }
}
