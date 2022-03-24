using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem1051
    {
        public int HeightChecker(int[] heights)
        {
            int[] copy = new int[heights.Length];
            int ret = 0;
            for(int i = 0; i < heights.Length;i++)
            {
                copy[i] = heights[i];
            }
            var heightList = heights.ToList();
            heightList.Sort();

            for (int i = 0; i < heights.Length; i++)
            {
                if (copy[i] != heightList[i])
                {
                    ret++;
                }
            }
            return ret;
        }
    }
}
