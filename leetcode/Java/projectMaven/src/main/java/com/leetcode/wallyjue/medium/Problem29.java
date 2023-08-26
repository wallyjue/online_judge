package com.leetcode.wallyjue.medium;

public class Problem29 {
    public int divide(int dividend, int divisor) {
        if (divisor == -1 && dividend == -2147483648)
        {
            return 2147483647;
        }
        int ret = dividend / divisor;
        return ret;
    }
}
