package com.leetcode.wallyjue.easy;

public class Problem643 {
    public double findMaxAverage(int[] nums, int k) {
        double ret = 0;
        double sum = 0;
        double max = 0;
        for (int cnt = 0; cnt < k;cnt++)
        {
            sum += nums[cnt];
        }
        ret = sum / k;
        max = sum;

        for (int cnt = k;cnt < nums.length;cnt++)
        {
            sum = sum + nums[cnt] - nums[cnt -k];
            max = Double.max(max, sum);
            ret = Double.max(max / (double)k, ret);
        }
        return ret;
    }
}
