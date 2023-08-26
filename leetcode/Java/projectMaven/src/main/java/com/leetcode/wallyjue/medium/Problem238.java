package com.leetcode.wallyjue.medium;

public class Problem238 {
    public int[] productExceptSelf(int[] nums) {
        int[] forward = new int[nums.length];
        int[] backward = new int[nums.length];
        int[] ret = new int[nums.length];
        for(int cnt = 0; cnt < nums.length;cnt++) {
            if (cnt == 0) {
                forward[cnt] = nums[cnt];
                backward[nums.length - cnt - 1] = nums[nums.length - cnt - 1];
            }
            else {
                forward[cnt] = nums[cnt] * forward[cnt-1];
                backward[nums.length - cnt - 1] = nums[nums.length - cnt - 1] * backward[nums.length - cnt];
            }
        }
        ret[0] = backward[1];
        ret[nums.length - 1] = forward[nums.length - 1 - 1];
        for (int cnt = 1; cnt < nums.length - 1;cnt++)
        {
            ret[cnt] = backward[cnt+1] * forward[cnt-1];
        }
        return ret;
    }
}
