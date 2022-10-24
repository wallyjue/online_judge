using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem1143
    {
        // f(i,j) =
        // if (text1[i] == text2[j])
        //     1 + f(i-1, j-1)
        // else 
        //     Math.Max(f(i, j-1), f(i-1, j));

        int[][] result;
        public int LongestCommonSubsequence(string text1, string text2)
        {
            result = new int[text1.Length][];
            for (int cnt = 0; cnt < text1.Length;cnt++)
            {
                result[cnt] = new int[text2.Length]; 
            }

            int i = 1, j = 1;
            while (i <= text1.Length && j <= text2.Length)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    result[i][j] = 1 + result[i - 1][j - 1];
                    i++;
                    j++;
                }
                else
                {
                    if (result[i][j - 1] > result[i - 1][j])
                    {
                        result[i][j] = result[i][j - 1];
                        j++;
                    }
                    else
                    {
                        result[i][j] = result[i - 1][j];
                        i++;
                    }
                }
            }

            return result[text1.Length][text2.Length];
        }
    }
}
