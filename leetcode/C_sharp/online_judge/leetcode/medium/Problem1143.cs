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
            result = new int[text1.Length + 1][];
            for (int cnt = 0; cnt < text1.Length + 1;cnt++)
            {
                result[cnt] = new int[text2.Length + 1]; 
            }

            for (int i = 1; i <= text1.Length; i++)
            {
                for (int j = 1; j <= text2.Length; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        result[i][j] = 1 + result[i - 1][j - 1];
                    }
                    else
                    {
                        result[i][j] = Math.Max(result[i - 1][j], result[i][j - 1]);
                    }
                }
            }

            
            return result[text1.Length][text2.Length];
        }
    }
}
