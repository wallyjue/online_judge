using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem200
    {
        char[][] grid;
        public int NumIslands(char[][] grid)
        {
            this.grid = grid;
            int ret = 0;
            for(int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[x].Length; y++)
                {
                    bool isLand = false;
                    isLand = dfs(x, y, grid.Length, grid[x].Length, isLand);
                    if (isLand)
                    {
                        ret++;
                    }
                }
            }
            return ret;
        }

        private bool dfs(int x, int y, int xLimit, int yLimit, bool isLand)
        {
            if (x >= 0 && y >= 0 && x < xLimit && y < yLimit && this.grid[x][y] == '1')
            {
                isLand = true;
                this.grid[x][y] = '2';
                if (x >= 0 && x < xLimit)
                {
                    isLand = dfs(x - 1, y, xLimit, yLimit, isLand);
                    isLand = dfs(x + 1, y, xLimit, yLimit, isLand);
                }
                if (y< yLimit && y >= 0)
                {
                    isLand = dfs(x, y - 1, xLimit, yLimit, isLand);
                    isLand = dfs(x, y + 1, xLimit, yLimit, isLand);
                }
            }

            return isLand;
        }
    }
}
