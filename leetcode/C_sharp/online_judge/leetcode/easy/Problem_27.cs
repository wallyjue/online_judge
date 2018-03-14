using System;

namespace online_judge.leetcode.easy
{
    class Problem_27
    {
		public int RemoveElement(int[] nums, int val)
		{
			int ret = 0, temp = 0, swap_cnt = 0;
			for (int cnt = 0; cnt < nums.Length; cnt++)
			{
				if (nums[cnt] != val) ret++;
			}

			for (int cnt = 0; cnt < nums.Length; cnt++)
			{
				if(nums[cnt] == val)
				{
					for (int cnt2 = cnt+1; cnt2 < nums.Length; cnt2++)
					{
						if(nums[cnt2] != val)
						{
							temp = nums[cnt];
							nums[cnt] = nums[cnt2];
							nums[cnt2] = temp;
							swap_cnt++;
							break;
						}
					}
				}
			}
			Array.Resize(ref nums, ret);
			return ret;
		}
	}
}
