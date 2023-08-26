package com.leetcode.wallyjue.medium;

import java.util.Arrays;
import java.util.HashMap;
import java.util.PriorityQueue;

public class Problem1657 {
    public boolean closeStrings(String word1, String word2) {
        if (word1.length() != word2.length())
            return false;

        HashMap<Character, Integer> map = new HashMap<>();
        PriorityQueue<Integer> queue1 = new PriorityQueue<>();
        for (int cnt = 0; cnt < word1.length();cnt++)
        {
            int count = map.getOrDefault(word1.charAt(cnt), 0);
            map.put(word1.charAt(cnt), count + 1);
        }
        StringBuffer w1 = new StringBuffer();
        for(Character item: map.keySet())
            w1.append(item);

        for(Integer value: map.values())
            queue1.add(value);

        map = new HashMap<>();
        PriorityQueue<Integer> queue2 = new PriorityQueue<>();
        for (int cnt = 0; cnt < word2.length();cnt++)
        {
            int count = map.getOrDefault(word2.charAt(cnt), 0);
            map.put(word2.charAt(cnt), count + 1);
        }
        StringBuffer w2 = new StringBuffer();
        for(Character item: map.keySet())
            w2.append(item);

        char[] wd1 = w1.toString().toCharArray();
        char[] wd2 = w2.toString().toCharArray();
        Arrays.sort(wd1);
        Arrays.sort(wd2);
        if (wd1.length != wd2.length) return false;
        for(int cnt = 0; cnt < wd1.length;cnt++)
            if (wd1[cnt] != wd2[cnt]) return false;
        for(Integer value: map.values())
            queue2.add(value);

        if (queue1.size() != queue2.size())
            return false;

        while(!queue1.isEmpty())
        {
            Integer item1 = queue1.remove();
            Integer item2 = queue2.remove();
            if (item1.compareTo(item2) != 0)
                return false;
        }

        return true;
    }
}
