using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem2089
    {
        public IList<int> TargetIndices(int[] nums, int target)
        {
            List<int> ret = new List<int>();
            Array.Sort(nums);
            int left = FindLow(nums, target);
            int right = FindUpper(nums, target);

            for(int cnt = left; cnt <= right; cnt++)
            {
                ret.Add(cnt);
            }

            return ret;
        }

        private int FindLow(int[] nums, int target)
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

        private int FindUpper(int[] nums, int target)
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
    }
}
