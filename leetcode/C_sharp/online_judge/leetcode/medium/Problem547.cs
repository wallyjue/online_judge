using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem547
    {
        int[][] grid;
        public int FindCircleNum(int[][] isConnected)
        {
            this.grid = isConnected;
            int ret = 0;
            for (int city = 0; city < grid.Length; city++)
            {
                bool isLand = false;
                isLand = traversalByCity(city, grid.Length, isLand);
                if (isLand)
                {
                    ret++;
                }
            }
            return ret;
        }

        private bool traversalByCity(int x, int xLimit, bool isLand)
        {
            for (int cnt = 0; cnt < xLimit; cnt++)
            {
                if (this.grid[cnt][x] == 1)
                {
                    isLand = true;
                    this.grid[cnt][x] = 2;
                    isLand = traversalByCity(cnt, xLimit, isLand);
                }
            }

            return isLand;
        }


    }
}
