using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem154
    {
        public int FindMin(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            if (nums[left] < nums[right])
            {
                return nums[left];
            }

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right--;
                }
            }

            return nums[left];
        }
    }
}
