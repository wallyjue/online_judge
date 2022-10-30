using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.tests
{
    internal class Nomura4
    {
        // dynamic function
        // dp(p) = 

        public int solution(int[] A)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                table.Add(A[i], i);
            }
            int ret = 0;
            return ret;
            // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
        }
    }
}
