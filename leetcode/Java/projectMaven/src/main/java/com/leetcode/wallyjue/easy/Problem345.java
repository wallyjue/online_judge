package com.leetcode.wallyjue.easy;

import java.util.HashSet;
import java.util.LinkedList;

public class Problem345 {
    public String reverseVowels(String s) {
        StringBuffer ret = new StringBuffer();
        LinkedList<Character> queue = new LinkedList<>();
        HashSet<Character> vowels = new HashSet<>();
        vowels.add('a');
        vowels.add('e');
        vowels.add('i');
        vowels.add('o');
        vowels.add('u');
        vowels.add('A');
        vowels.add('E');
        vowels.add('I');
        vowels.add('O');
        vowels.add('U');
        for (int cnt = 0;cnt < s.length();cnt++)
        {
            if (vowels.contains(s.charAt(cnt)))
            {
                queue.add(s.charAt(cnt));
            }
        }

        for (int cnt = 0;cnt < s.length();cnt++)
        {
            if (vowels.contains(s.charAt(cnt)))
            {
                ret.append(queue.removeLast());
            }
            else
            {
                ret.append(s.charAt(cnt));
            }
        }

        return ret.toString();
    }
}
