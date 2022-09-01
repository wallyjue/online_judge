using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem154
    {
        public int FindMin2(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            if (nums[left] < nums[right])
            {
                return nums[left];
            }

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mid > 0 && nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }

                if (mid < nums.Length - 1 && nums[mid] > nums[mid + 1])
                {
                    return nums[mid + 1];
                }

                if (nums[mid] < nums[left])
                {
                    right = mid - 1;
                }
                else if (nums[mid] > nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    if (nums[left] > nums[right])
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return nums[left];
        }


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
