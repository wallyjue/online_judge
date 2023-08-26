package com.leetcode.wallyjue.medium;

import java.util.LinkedList;

public class Problem2390 {
    public String removeStars(String s) {
        LinkedList<Character> stack = new LinkedList<>();

        for (int cnt = 0;cnt < s.length();cnt++)
        {
            if (s.charAt(cnt) != '*')
                stack.push(s.charAt(cnt));
            else
                stack.pop();
        }

        StringBuffer sb = new StringBuffer();
        while(!stack.isEmpty())
            sb.append(stack.removeLast());

        return sb.toString();
    }
}
