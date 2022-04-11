using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem96
    {

        public int NumTrees(int n)
        {
            int[] G = new int[n + 1];
            G[1] = 1;
            G[2] = 2;
            
            for (int i = 2; i < n; i++)
            {
                for (int j = 1; j < n -1; j++)
                {
                    G[i] += G[j -1] * G[i - j];
                }
            }
            return G[n];
        }
    }
}
