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
            int[] trappedWater = new int[height.Length];
            int[] lmax = new int[height.Length];
            int[] rmax = new int[height.Length];

            for(int cnt = 0; cnt < height.Length; cnt++)
            {
                if (cnt == 0)
                {
                    lmax[cnt] = 0;
                }
                else
                {
                    lmax[cnt] = Math.Max(lmax[cnt - 1], height[cnt - 1]);
                }
            }

            for (int cnt = height.Length - 1; cnt > 0; cnt--)
            {
                if (cnt == height.Length - 1)
                {
                    rmax[cnt] = 0;
                }
                else
                {
                    rmax[cnt] = Math.Max(rmax[cnt + 1], height[cnt + 1]);
                }
            }

            for (int cnt = 0; cnt < height.Length; cnt++)
            {
                trappedWater[cnt] = Math.Min(lmax[cnt], rmax[cnt]) - height[cnt];
                if (trappedWater[cnt] > 0)
                {
                    ret += trappedWater[cnt];
                }
            }

            return ret;
        }

        
    }
}
