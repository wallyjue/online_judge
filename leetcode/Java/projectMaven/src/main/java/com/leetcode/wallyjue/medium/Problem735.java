package com.leetcode.wallyjue.medium;

import java.util.LinkedList;

public class Problem735 {
    public int[] asteroidCollision(int[] asteroids) {
        LinkedList<Integer> ret = new LinkedList<>();
        Integer prev = null;
        boolean insert = false;
        for (int cnt = 0;cnt < asteroids.length;cnt++)
        {
            insert = true;
            if (asteroids[cnt] < 0)
            {
                while(!ret.isEmpty())
                {
                    prev = ret.peekLast();
                    if (prev < 0)
                        break;

                    if (asteroids[cnt] + prev == 0)
                    {
                        insert = false;
                        ret.removeLast();
                        break;
                    }
                    else if (asteroids[cnt] + prev < 0)
                    {
                        ret.removeLast();
                        insert = true;
                    }
                    else
                    {
                        insert = false;
                        break;
                    }
                }
            }

            if(insert)
                ret.addLast(asteroids[cnt]);
        }
        int[] ans = new int[ret.size()];
        for (int cnt = 0;cnt < ans.length;cnt++)
            ans[cnt] = ret.removeFirst();

        return ans;
    }
}
