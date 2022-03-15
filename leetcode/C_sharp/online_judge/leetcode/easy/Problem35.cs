using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    public class Problem35
    {
        public int SearchInsert(int[] nums, int target)
        {
            /*
            if (target > nums[nums.Length -1])
            {
                return nums.Length;
            }
            else if (target < nums[0])
            {
                return 0;
            }*/

            int left = 0, right = nums.Length -1;
            while (left + 1 < right)
            {
                int mid = left + (right - left) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    left = mid +1;
                }
                else
                {
                    right = mid;
                }

            }
            if (target > nums[right])
            {
                return right + 1;
            }
            else if (target <= nums[left])
            {
                return left;
            }
            else if (target == nums[right])
            {
                return right;
            }


            return right;
        }
    }
}
