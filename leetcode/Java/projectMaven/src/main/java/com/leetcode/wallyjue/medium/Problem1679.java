package com.leetcode.wallyjue.medium;

import java.util.HashMap;

public class Problem1679 {
    public int maxOperations(int[] nums, int k) {
        int ret = 0;
        HashMap<Integer, Integer> numSet = new HashMap<>();
        for (int cnt = 0; cnt < nums.length;cnt++)
        {
            Integer count = numSet.getOrDefault(nums[cnt], 0);
            numSet.put(nums[cnt], count+1);
        }

        for (int cnt = 0; cnt < nums.length;cnt++)
        {
            if (numSet.containsKey(k - nums[cnt]) && numSet.get(k - nums[cnt]) > 0)
            {
                Integer count = numSet.get(k - nums[cnt]);
                if (k - nums[cnt] == nums[cnt] && count < 2)
                    continue;

                numSet.put(k - nums[cnt], count - 1);
                if (count - 1 == 0)
                    numSet.remove(k - nums[cnt]);

                count = numSet.get(nums[cnt]);
                if (count == null)
                    continue;
                numSet.put(nums[cnt], count - 1);
                if (count - 1 == 0)
                    numSet.remove(nums[cnt]);
                ret++;
            }
        }

        return ret;
    }
}
