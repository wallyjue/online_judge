using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem2447
    {
        public int SubarrayGCD(int[] nums, int k)
        {
            if (k == 0) return 0;

            int subcnt = 0;
            int right = 1;
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (nums[cnt] == k) subcnt++;
            }


            while (right < nums.Length)
            {
                bool hasK = false;
                for (int cnt = right - 1; cnt >= 0; cnt--)
                {
                    if (nums[cnt] % k != 0)
                    {
                        break;
                    }
                    else
                    {
                        int gcdnum = gcd(nums[right], nums[cnt]);

                        if (gcdnum == k)
                        {
                            subcnt++;
                            hasK = true;
                        }
                        else if (gcdnum % k == 0 && hasK)
                        {
                            subcnt++;
                        }
                    }
                }
                right++;
            }
            return subcnt;
        }

        private int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
    }
}
