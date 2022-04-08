using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem779
    {
        public int KthGrammar(int n, int k)
        {
            if (n == 1 && k == 1)
                return 0;

            int mid = (int)Math.Pow(2, n - 1) / 2;

            if (k <= mid)
            {
                return KthGrammar(n - 1, k);

            }
            else
            {
                return KthGrammar(n - 1, (k - mid)) == 0 ? 1 : 0;
            }
        }
    }
}
