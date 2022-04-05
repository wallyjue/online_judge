using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem11
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int max = 0;
            while (left < right)
            {
                int width = right - left;
                int currheight = Math.Min(height[left], height[right]);
                int area = currheight * width;
                max = Math.Max(max, area);
                if (height[left] < height[right]) left++;
                else if (height[left] > height[right]) right--;
                else
                {
                    left++;
                    right--;
                }
            }
            return max;
        }
    }
}
