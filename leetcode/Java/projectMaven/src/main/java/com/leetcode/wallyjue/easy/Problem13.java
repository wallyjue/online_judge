package com.leetcode.wallyjue.easy;

class Problem13 {
    public int romanToInt(String s) {
        int ret = 0;
        char prev = 'a';
        for(int index = 0; index < s.length();index++)
        {
            switch(s.charAt(index))
            {
                default:
                    break;
                case 'M':
                    if (prev == 'C')
                    {
                        ret += 800;
                    }
                    else
                    {
                        ret += 1000;
                    }
                    prev = 'M';
                    break;
                case 'D':
                    if (prev == 'C')
                    {
                        ret += 300;
                    }
                    else
                    {
                        ret += 500;
                    }
                    prev = 'D';
                    break;
                case 'C':
                    if (prev == 'X')
                    {
                        ret += 80;
                    }
                    else
                    {
                        ret += 100;
                    }
                    prev = 'C';
                    break;
                case 'X':
                    if (prev == 'I')
                    {
                        ret += 8;
                    }
                    else
                    {
                        ret += 10;
                    }
                    prev = 'X';
                    break;
                case 'I':
                    prev = 'I';
                    ret += 1;
                    break;
                case 'L':
                    if (prev == 'X')
                    {
                        ret += 30;
                    }
                    else
                    {
                        ret += 50;
                    }
                    prev = 'L';
                    break;
                case 'V':
                    if (prev == 'I')
                    {
                        ret += 3;
                    }
                    else
                    {
                        ret += 5;
                    }
                    prev = 'V';
                    break;
            }
        }
        return ret;

    }
}