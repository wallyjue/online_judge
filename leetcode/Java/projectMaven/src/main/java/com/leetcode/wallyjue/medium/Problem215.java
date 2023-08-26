package com.leetcode.wallyjue.medium;

import java.util.Comparator;
import java.util.PriorityQueue;

public class Problem215 {
    public int findKthLargest(int[] nums, int k) {
        PriorityQueue<Integer> queue = new PriorityQueue<>(Comparator.reverseOrder());
        for(int cnt = 0; cnt < nums.length; cnt++)
        {
            queue.add(nums[cnt]);
        }
        for(int cnt = 0;cnt < k - 1;cnt++)
        {
            queue.remove();
        }
        int ret = queue.peek();
        return ret;
    }
}
