using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.easy
{
    class Problem26
    {
		public int RemoveDuplicates(int[] nums)
		{
			Dictionary<int, int> keyCount = new Dictionary<int, int>();
			for(int cnt = 0; cnt < nums.Length; cnt++)
			{
				int valueCount = keyCount.GetValueOrDefault(nums[cnt]);
				keyCount.Remove(nums[cnt]);
				keyCount.Add(nums[cnt], valueCount+1);
			}
			int next = Int32.MinValue, pivot = 0;
			for (int cnt = 0; cnt < nums.Length; cnt++)
			{
				if( next < nums[cnt]) 
				{
					nums[pivot] = nums[cnt];
					next = nums[pivot];
					pivot++;
				}
			}
			return keyCount.Count;
		}

	}
}
