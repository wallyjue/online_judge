package com.leetcode.wallyjue.easy;

import java.util.LinkedList;
import java.util.List;

public class Problem1431 {
    public List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        int max = Integer.MIN_VALUE;
        LinkedList<Boolean> ret = new LinkedList<>();
        for (int cnt = 0; cnt < candies.length;cnt++) {
            max = Integer.max(max, candies[cnt]);
        }

        for (int cnt = 0; cnt < candies.length;cnt++) {
            if (candies[cnt] + extraCandies >= max) {
                ret.add(true);
            } else {
                ret.add(false);
            }
        }
        return ret;
    }
}
