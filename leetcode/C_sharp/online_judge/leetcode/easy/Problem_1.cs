using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.easy
{
    class Problem_1
    {
		public int[] TwoSum(int[] nums, int target)
		{
			int ret1 = 0, ret2 = 0;
			for(int cnt = 0; cnt < nums.Length; cnt++)
			{
				for(int cnt2 = cnt+1; cnt2 < nums.Length; cnt2++)
				{
					if(nums[cnt] + nums[cnt2] == target)
					{
						ret1 = cnt;
						ret2 = cnt2;
						break;
					}
				}
			}


			int[] ret = { ret1, ret2 };
			return ret;
		}
	}
}
