using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem16
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int ret = int.MaxValue;
            int minDiff = int.MaxValue;
            int left = 0, right = nums.Length - 1;
            for (int fix = 0; fix < nums.Length; fix++)
            {
                left = fix + 1;
                right = nums.Length - 1;
                
                while (left < right)
                {
                    int remain = target - nums[fix] - nums[left] - nums[right];
                    if (remain == 0)
                    {
                        return nums[left] + nums[right] + nums[fix];
                    }
                    if (Math.Abs(remain) < minDiff)
                    {
                        minDiff = Math.Abs(remain);
                        ret = nums[left] + nums[right] + nums[fix];
                    }
                    if (remain < 0)
                    {
                        right--;

                    }
                    else
                    {
                        left++;
                    }

                }
            }

            return ret;
        }
    }
}
