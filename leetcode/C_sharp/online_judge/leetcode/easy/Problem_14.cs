using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem_14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string ret = string.Empty;
            for (int x = 0; x < strs[0].Length; x++)
            {
                bool isEqual = true;
                for (int y = 1; y < strs.Length; y++)
                {
                    if (strs[y].Length < x+1 || strs[0][x] != strs[y][x])
                    {
                        isEqual = false;
                        break;
                    }
                }

                if (isEqual)
                {
                    ret += strs[0][x];
                }
                else
                {
                    break;
                }
            }

            return ret;
        }
    }
}
