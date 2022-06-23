using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem33
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                return target == nums[0] ? 0 : -1;
            }

            int pivot = FindK(nums);
            int ret = binarySearch(nums, target, 0, pivot);
            if (ret >= 0 )
            {
                return ret;
            }

            ret = binarySearch(nums, target, pivot + 1, nums.Length - 1);
            
            return ret;
        }

        private int FindK(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            if (nums[left] < nums[right])
            {
                return 0;
            }


            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    return mid;
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

        private int binarySearch(int[] nums, int target, int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
