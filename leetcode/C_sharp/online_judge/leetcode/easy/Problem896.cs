using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem896
    {
        public bool IsMonotonic(int[] nums)
        {
            bool ret = true;
            if (nums.Length == 1) return ret;
            if (nums.Length == 2) return ret;

            bool isIncreasing = nums[0] <= nums[nums.Length - 1];
            bool isDecreasing = nums[0] >= nums[nums.Length - 1];

            for(int cnt = 2; cnt < nums.Length;cnt++)
            {
                if (isIncreasing)
                {
                    ret &= nums[cnt] >= nums[cnt - 1] && nums[cnt - 1] >= nums[cnt - 2];
                }

                if (isDecreasing)
                {
                    ret &= nums[cnt] <= nums[cnt - 1] && nums[cnt - 1] <= nums[cnt - 2];
                }
            }

            return ret;
        }
    }
}
