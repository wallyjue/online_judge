using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem75
    {
        public void SortColors(int[] nums)
        {
            int p0 = 0, p2 = nums.Length - 1;
            int ptr = 0;
            int temp = 0;
            while (ptr <= p2)
            {
                if (nums[ptr] == 0)
                {
                    temp = nums[ptr];
                    nums[p0++] = nums[ptr];
                    nums[ptr++] = temp;
                }
                else if (nums[ptr] == 2)
                {
                    temp = nums[ptr];
                    nums[ptr] = nums[p2];
                    nums[p2--] = temp;
                }
                else
                {
                    ptr++;
                }
            }
        }
    }
}
