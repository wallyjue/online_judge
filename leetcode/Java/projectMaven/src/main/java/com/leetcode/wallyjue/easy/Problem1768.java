package com.leetcode.wallyjue.easy;

public class Problem1768 {
    public String mergeAlternately(String word1, String word2) {
        int length1 = word1.length();
        int length2 = word2.length();
        StringBuilder sb = new StringBuilder();
        int l1 = 0, l2 = 0;
        for(; l2 < length2 || l1 < length1;)
        {
            if (l1 < length1)
            {
                sb.append(word1.charAt(l1++));
            }

            if (l2 < length2)
            {
                sb.append(word2.charAt(l2++));
            }
        }
        return sb.toString();
    }
}
