using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.easy
{
    class Problem1
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

		public int[] TwoSum2(int[] nums, int target)
		{
			Hashtable table = new Hashtable();
			int ret1 = 0, ret2 = 0;
			for (int cnt = 0; cnt < nums.Length; cnt++)
			{
				if (table.ContainsKey(target - nums[cnt]))
                {
					ret2 = cnt;
					ret1 = (int)table[target - nums[cnt]];
					break;
                }

				if (!table.ContainsKey(nums[cnt]))
                {
					table.Add(nums[cnt], cnt);
				}
				
			}


			int[] ret = { ret1, ret2 };
			return ret;
		}
	}
}
