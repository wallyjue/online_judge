using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem74
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            bool ret = false;
            for (int cnt = 0; cnt < matrix.Length; cnt++)
            {
                if (matrix[cnt][0] <= target && matrix[cnt][matrix[cnt].Length - 1] >= target)
                {
                    ret = binarySearch(matrix[cnt], target);
                    if (ret)
                        return ret;
                }
            }

            return ret;
        }

        private bool binarySearch(int[] nums, int target)
        {
            bool ret = false;
            int left = 0, right = nums.Length - 1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ret;
        }
    }
}
