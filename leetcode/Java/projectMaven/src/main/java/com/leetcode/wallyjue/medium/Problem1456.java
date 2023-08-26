package com.leetcode.wallyjue.medium;

import java.util.HashMap;

public class Problem1456 {
    public int maxVowels(String s, int k) {
        int max = 0, cur = 0;
        HashMap<Character, Boolean> vowels = new HashMap<>();
        vowels.put('a', true);
        vowels.put('e', true);
        vowels.put('i', true);
        vowels.put('o', true);
        vowels.put('u', true);

        HashMap<Character, Integer> win = new HashMap<>();
        for (int cnt = 0;cnt < k;cnt++)
        {
            Integer count = win.getOrDefault(s.charAt(cnt), 0);
            win.put(s.charAt(cnt), count);
            if (vowels.containsKey(s.charAt(cnt)))
                cur++;
        }
        max = cur;
        for (int cnt = k;cnt < s.length();cnt++)
        {
            if (vowels.containsKey(s.charAt(cnt)) && !vowels.containsKey(s.charAt(cnt - k)))
                cur++;
            else if (!vowels.containsKey(s.charAt(cnt)) && vowels.containsKey(s.charAt(cnt - k)))
                cur--;

            max = Integer.max(max, cur);
        }

        return max;
    }
}
