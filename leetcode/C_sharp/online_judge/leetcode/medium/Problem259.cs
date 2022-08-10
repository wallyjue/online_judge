using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem259
    {
        public int ThreeSumSmaller(int[] nums, int target)
        {
            int ret = 0;
            Array.Sort(nums);
            int right = nums.Length - 1;
            int left = 0;
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                int remaining = target - nums[cnt];
                right = nums.Length - 1;
                left = cnt + 1;
                while (left < right)
                {
                    
                    if (nums[left] + nums[right] < remaining)
                    {
                        ret += right - left;
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return ret;
        }
    }
}
