package com.leetcode.wallyjue.medium;

public class Problem1493 {
    public int longestSubarray(int[] nums) {
        int max = Integer.MIN_VALUE;
        int cur = 0;
        int zeroCnt = 0;
        int zeroIndex = -1;

        for (int cnt = 0;cnt < nums.length;cnt++)
        {
            if (nums[cnt] == 1)
                cur++;
            else
            {
                if (zeroCnt == 0)
                    zeroCnt++;
                else
                {
                    if (zeroIndex == cnt - 1)
                    {
                        max = Integer.max(max, cur);
                        cur = 0;
                    }
                    else
                    {
                        max = Integer.max(max, cur);
                        cur = cnt - zeroIndex - 1;
                    }
                }
                zeroIndex = cnt;
            }
        }
        max = Integer.max(max, cur);
        return zeroCnt == 0 ? max - 1 : max;
    }
}
