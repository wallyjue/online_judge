package com.leetcode.wallyjue.easy;

import java.util.HashSet;
import java.util.LinkedList;
import java.util.List;

public class Problem2215 {
    public List<List<Integer>> findDifference(int[] nums1, int[] nums2) {
        LinkedList<List<Integer>> ret = new LinkedList<List<Integer>>();
        HashSet<Integer> set1 = new HashSet<>();
        HashSet<Integer> set2 = new HashSet<>();

        for (int cnt = 0; cnt < nums1.length; cnt++)
            set1.add(nums1[cnt]);
        for (int cnt = 0; cnt < nums2.length; cnt++)
            set2.add(nums2[cnt]);

        List<Integer> list1 = new LinkedList<>();
        List<Integer> list2 = new LinkedList<>();

        for (int cnt = 0; cnt < nums1.length;cnt++)
            if (!set2.contains(nums1[cnt]) && !list1.contains(nums1[cnt]))
                list1.add(nums1[cnt]);

        for (int cnt = 0;cnt < nums2.length;cnt++)
            if (!set1.contains(nums2[cnt]) && !list2.contains(nums2[cnt]))
                list2.add(nums2[cnt]);

        ret.add(list1);
        ret.add(list2);
        return ret;
    }
}
