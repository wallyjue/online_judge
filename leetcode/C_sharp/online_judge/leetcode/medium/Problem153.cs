using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem153
    {
        public int FindMin(int[] nums)
        {
            int ret = FindPivot(nums);

            return ret;
        }

        private int FindPivot(int[] nums)
        {
            if (nums[0] <= nums[nums.Length - 1])
            {
                return nums[0];
            }

            int left = 0, right = nums.Length - 1;
            while(left <= right)
            {
                

                int mid = (left + right) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }
                if (nums[mid] < nums[left])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }
    }
}
