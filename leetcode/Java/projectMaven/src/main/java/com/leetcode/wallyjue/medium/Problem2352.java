package com.leetcode.wallyjue.medium;

import java.util.HashMap;

public class Problem2352 {
    public int equalPairs(int[][] grid) {
        int ans = 0;
        int cnt = 0;
        StringBuffer[] columns = new StringBuffer[grid.length];
        StringBuffer[] rows = new StringBuffer[grid.length];
        HashMap<String, Integer> map = new HashMap<>();
        for (int c = 0; c < grid.length;c++)
        {
            columns[c] = new StringBuffer();
            rows[c] = new StringBuffer();
        }

        for (int c = 0; c < grid[0].length;c++)
        {
            for (int r = 0; r < grid.length;r++)
            {
                columns[cnt].append(grid[r][c]);
                columns[cnt].append(',');
                rows[cnt].append(grid[c][r]);
                rows[cnt].append(',');
            }

            int count = map.getOrDefault(columns[cnt].toString(), 0);
            map.put(columns[cnt].toString(), count + 1);
            cnt++;
        }
        for (int r = 0; r < grid.length;r++)
        {
            ans += map.getOrDefault(rows[r].toString(), 0);
        }
        return ans;
    }
}
