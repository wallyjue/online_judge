package com.leetcode.wallyjue.medium;

public class Problem334 {
    public boolean increasingTriplet(int[] nums) {
        if (nums.length < 3)
        {
            return false;
        }

        int i = nums[0], j = Integer.MAX_VALUE;
        for (int cnt = 0; cnt < nums.length;cnt++)
        {
            if (nums[cnt] <= i)
            {
                i = nums[cnt];
            }
            else if (nums[cnt] <= j)
            {
                j = nums[cnt];
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}
