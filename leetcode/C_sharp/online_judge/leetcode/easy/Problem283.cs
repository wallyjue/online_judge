﻿using online_judge.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem283
    {
        public void MoveZeroes2(int[] nums)
        {
            int ptr = 0;
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (nums[cnt] != 0)
                {
                    nums[ptr++] = nums[cnt];
                }
            }
            while (ptr < nums.Length)
            {
                nums[ptr++] = 0;
            }
        }




        public void MoveZeroes(int[] nums)
        {
            int ptr = 0, nonzeroPtr = 0;
            while (nonzeroPtr < nums.Length && ptr < nums.Length)
            {
                if (nums[nonzeroPtr] == 0 || ptr > nonzeroPtr)
                {
                    nonzeroPtr++;
                    continue;
                }

                if (nums[ptr] != 0)
                {
                    ptr++;
                    continue;
                }

                int temp = nums[ptr];
                nums[ptr] = nums[nonzeroPtr];
                nums[nonzeroPtr] = temp;

                ptr++;
            }

            Console.WriteLine(Helper.IteratingString(nums));
        }
    }
}
