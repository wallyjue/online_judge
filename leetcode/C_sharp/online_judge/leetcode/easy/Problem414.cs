using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem414
    {
        public int ThirdMax(int[] nums)
        {
            int? first = null, second = null, third = null;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == first || nums[i] == second || nums[i] == third) continue;

                if (nums[i] > first || first == null)
                {
                    third = second;
                    second = first;
                    first = nums[i];
                    continue;
                }

                if (nums[i] > second || second == null)
                {
                    third = second;
                    second = nums[i];
                    continue;
                }

                if (nums[i] > third || third == null)
                {
                    third = nums[i];
                    continue;
                }
            }

            if (third == null) third = first;

            return third.Value;
        }
    }
}
