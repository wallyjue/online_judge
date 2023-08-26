package com.leetcode.wallyjue.easy;

import java.util.HashMap;
import java.util.HashSet;

public class Problem1207 {
    public boolean uniqueOccurrences(int[] arr) {
        HashMap<Integer, Integer> map = new HashMap<>();
        for (int cnt = 0; cnt < arr.length;cnt++)
        {
            int count = map.getOrDefault(arr[cnt], 0);
            map.put(arr[cnt], count + 1);
        }

        HashSet<Integer> set = new HashSet<>();
        for (Integer item : map.values())
        {
            if (set.contains(item))
                return false;

            set.add(item);
        }

        return true;
    }
}
