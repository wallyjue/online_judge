using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem905
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int write = 0, read = 1;

            for (read = 0; read < nums.Length;read++)
            {
                if (nums[read] % 2 == 0 || nums[read] == 0)
                {
                    int temp = nums[read];
                    nums[read] = nums[write];
                    nums[write] = temp;
                    write++;
                }
            }

            return nums;
        }
    }
}
