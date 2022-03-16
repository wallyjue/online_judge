using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    public class Problem70
    {
        /*
         * f(n) = f(n-1) + f(n-2)
         */
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            int[] steps = new int[n+1];
            steps[1] = 1;
            steps[2] = 2;
            steps[3] = 3;
            for(int i = 4; i <= n; i++)
            {
                steps[i] = steps[i-1] + steps[i-2];
            }

            return steps[n];
        }
    }
}
