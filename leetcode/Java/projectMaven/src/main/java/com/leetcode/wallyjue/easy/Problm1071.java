package com.leetcode.wallyjue.easy;

public class Problm1071 {
    public String gcdOfStrings(String str1, String str2) {
        String ret = new String();
        if (str1 == str2)
        {
            return str1;
        }

        String shorterOne = str1.length() > str2.length() ? str2 : str1;
        String longerOne = str1.length() > str2.length() ? str1 : str2;
        return isGCDString(shorterOne, longerOne);
    }

    private String isGCDString(String shorterOne, String longerOne)
    {
        while(longerOne.length() > 0)
        {
            if( shorterOne.compareTo(longerOne.substring(0, shorterOne.length())) == 0)
            {
                longerOne = longerOne.substring(shorterOne.length());
                if (longerOne.length() == 0 || longerOne.compareTo(shorterOne) == 0)
                {
                    return shorterOne;
                }
            }
            else
            {
                //longerOne = longerOne.substring(0, longerOne.length() - 1);
                //if (longerOne.length() == 0)
                //{
                return "";
                //}
            }

            if (longerOne.length() < shorterOne.length())
            {
                String temp = longerOne;
                longerOne = shorterOne;
                shorterOne = temp;
            }
        }
        return "";
    }
}
