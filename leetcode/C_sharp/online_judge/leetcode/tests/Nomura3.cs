using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.tests
{
    internal class Nomura3
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)
            int Max = A.Max();
            int ret = 0;
            bool isIsland = false;
            for (int y = 1; y <= Max; y++)
            {
                for (int x = 0; x < A.Length; x++)
                {
                    if (x == 0)
                    {
                        if (A[x] >= y)
                        {
                            ret++;
                            isIsland = true;
                        }
                    }
                    else
                    {
                        if (A[x] >= y && !isIsland)
                        {
                            isIsland = true;
                            ret++;
                        }

                        if (A[x] < y)
                        {
                            if (isIsland)
                            {
                                isIsland = false;
                            }
                        }
                    }

                }
                isIsland = false;
            }

            return ret;
        }
    }
}
