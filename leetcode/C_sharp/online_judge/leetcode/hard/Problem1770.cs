using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.hard
{
    internal class Problem1770
    {
        // f(n, left) = Max( multiplier[n]*nums[right] + f(n-1, left), multiplier[n]*nums[left] f(n-1, left +1))
        int mSize, nSize;
        int[][] result;
        int[] nums;
        int[] multipliers;

        public int MaximumScore(int[] nums, int[] multipliers)
        {
            this.nums = nums;
            this.multipliers = multipliers;
            mSize = multipliers.Length;
            nSize = nums.Length;
            result = new int[nSize][];
            for (int cnt = 0; cnt < nSize;cnt++)
            {
                result[cnt] = new int[mSize];
            }
            int ret = dp(0, 0);
            return ret;
        }

        private int dp(int n, int left)
        {
            if (left >= nSize)
            {
                return 0;
            }

            if (n == mSize)
            {
                return 0;
            }

            int mult = multipliers[n];
            int right = nSize - 1 - (n - left);

            if (result[n][left] == 0)
            {
                result[n][left] = Math.Max(mult * nums[right] + dp(n + 1, left), mult * nums[left] + dp(n + 1, left + 1));
            }

            return result[n][left];
        }
    }
}
