using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem34
    {
        public int[] SearchRange(int[] nums, int target)
        {
            bool exist = binarySearch(nums, target);
            if (!exist)
            {
                return new int[] { -1, -1 };
            }
            int left = binarySearchLeft2(nums, target);

            int right = binarySearchRight2(nums, target);

            return new int [] { left, right };
        }

        private bool binarySearch(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return true;
                } 
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }

        private int binarySearchLeft2(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] >= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        private int binarySearchRight2(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return right;
        }


        private int binarySearchLeft(int[] nums, int target)
        {
            int left = 0, right = nums.Length -1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }

        private int binarySearchRight(int[] nums, int target)
        {
            int left = 0, right = nums.Length -1;

            while (left < right)
            {
                int mid = left + (right - left + 1) / 2;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid;
                }
            }
            return left;
        }
    }
}
