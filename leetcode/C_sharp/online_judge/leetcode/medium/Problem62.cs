using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem62
    {
        // f(m , n) = f(m-1,n) + f(m,n-1)
        int[][] paths;
        public int UniquePaths(int m, int n)
        {
            paths = new int[m][];
            for(int cnt = 0; cnt < m;cnt++)
            {
                paths[cnt] = new int[n];
            }

            for (int cnt = 0; cnt < m; cnt++)
            {
                paths[cnt][0] = 1;
            }

            for (int cnt = 0; cnt < n; cnt++)
            {
                paths[0][cnt] = 1;
            }

            for (int cnt = 1; cnt < m; cnt++)
            {
                for (int cnt2 = 1; cnt2 < n; cnt2++)
                {
                    paths[cnt][cnt2] = paths[cnt - 1][cnt2] + paths[cnt][cnt2 - 1];
                }
            }
            return paths[m - 1][n - 1];
        }
    }
}
