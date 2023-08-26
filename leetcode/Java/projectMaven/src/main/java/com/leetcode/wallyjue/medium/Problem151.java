package com.leetcode.wallyjue.medium;

import java.util.Stack;

public class Problem151 {
    public String reverseWords(String s) {
        StringBuffer ret = new StringBuffer();
        StringBuffer sb = new StringBuffer();
        Stack<String> stack = new Stack<String>();

        for (int cnt = 0;cnt < s.length();cnt++)
        {
            if (s.charAt(cnt) != ' ')
            {
                sb.append(s.charAt(cnt));
            }
            else
            {
                stack.add(sb.toString());
                sb = new StringBuffer();
            }
        }
        stack.add(sb.toString());
        while (!stack.isEmpty())
        {
            String temp = stack.pop();
            if (temp.trim().length() > 0)
            {
                if (ret.length() > 0)
                {
                    ret.append(' ');
                }
                ret.append(temp);
            }
        }
        return ret.toString();
    }
}
