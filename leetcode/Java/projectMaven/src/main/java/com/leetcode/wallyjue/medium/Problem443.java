package com.leetcode.wallyjue.medium;

import java.util.Arrays;

public class Problem443 {
    public int compress(char[] chars) {
        Character prev = null;
        Integer count = 0;
        int ptr = 0;
        for (int cnt = 0; cnt < chars.length;cnt++) {
            if (prev == null) {
                count++;
                prev = chars[cnt];
            } else if (chars[cnt] == prev) {
                count++;

            } else {
                chars[ptr++] = prev;
                if (count > 1) {
                    for(char a: count.toString().toCharArray()) {
                        chars[ptr++] = a;
                    }
                }
                count = 1;
                prev = chars[cnt];
            }

            if (cnt == chars.length - 1) {
                chars[ptr++] = prev;
                if (count > 1) {
                    for (char a : count.toString().toCharArray()) {
                        chars[ptr++] = a;
                    }
                }
            }
        }
        chars = Arrays.copyOf(chars, ptr);
        return ptr;
    }
}
