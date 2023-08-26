package com.leetcode.wallyjue.easy;

import java.util.HashMap;

public class Problem169 {
    public int majorityElement(int[] nums) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        int max = 0, maxIndex = 0;
        for (int num: nums)
        {
            if (map.containsKey(num))
            {
                int cnt = map.get(num);
                map.replace(num, cnt+1);
            }
            else
            {
                map.put(num, 1);
            }

            if (max < map.get(num))
            {
                max = map.get(num);
                maxIndex = num;
            }
        }

        return maxIndex;
    }
}
