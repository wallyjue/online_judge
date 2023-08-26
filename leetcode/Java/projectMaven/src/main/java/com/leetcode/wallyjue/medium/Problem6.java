package com.leetcode.wallyjue.medium;

public class Problem6 {
    public String convert(String s, int numRows) {
        StringBuffer ret = new StringBuffer();
        StringBuffer[] lists = new StringBuffer[numRows];
        for (int cnt = 0; cnt < numRows;cnt++)
        {
            lists[cnt] = new StringBuffer();
        }

        int listCnt = 0;
        boolean forward = true;
        for (int cnt = 0; cnt < s.length();cnt++)
        {
            lists[listCnt].append(s.charAt(cnt));
            if (listCnt + 1 == numRows)
            {
                forward = false;
            }
            else if (listCnt == 0)
            {
                forward = true;
            }
            if (numRows > 1)
            {
                if (forward)
                {
                    listCnt++;
                }
                else
                {
                    listCnt--;
                }
            }

        }
        for (int cnt = 0; cnt < numRows;cnt++)
        {
            ret.append(lists[cnt]);
        }
        return ret.toString();
    }
}
