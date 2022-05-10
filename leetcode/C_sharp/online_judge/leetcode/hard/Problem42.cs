using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem42
    {
        public int Trap(int[] height)
        {
            int ret = 0;
            int l = 0, r = 0;

            List<int> peaks = new List<int>();
            while(r < height.Length)
            {
                if (r+1 < height.Length && r > 0)
                {
                    if (height[r+1] < height[r] && height[r] > height[r-1])
                    {
                        Console.WriteLine("peak at:" + r);
                        peaks.Add(r);
                    }
                }
                else
                {
                    if (r == 0)
                    {
                        if (height[r+1] < height[r])
                        {
                            Console.WriteLine("peak at:" + r);
                            peaks.Add(r);
                        }
                    }
                    else
                    {
                        if (height[r - 1] < height[r])
                        {
                            Console.WriteLine("peak at:" + r);
                            peaks.Add(r);
                        }
                    }
                }
                r++;
            }

            int prevPeak = -1;
            foreach (int peak in peaks)
            {
                if (prevPeak >= 0)
                {
                    int limit = Math.Min(height[prevPeak], height[peak]);
                    for (int i = prevPeak + 1; i < peak; i++)
                    {
                        ret += limit - height[i];
                    }
                }
                prevPeak = peak;
            }
            return ret;
        }
    }
}
