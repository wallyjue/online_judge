package com.leetcode.wallyjue.easy;

public class Problem1732 {
    public int largestAltitude(int[] gain) {
        int max = 0, cur = 0;
        for (int cnt =0; cnt < gain.length;cnt++)
        {
            cur += gain[cnt];
            max = Integer.max(max, cur);
        }
        return max;
    }
}
