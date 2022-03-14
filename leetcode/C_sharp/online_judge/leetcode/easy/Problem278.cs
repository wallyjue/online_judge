using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    public class Problem278
    {
        int falsenumber;
        public Problem278(int falsenumber)
        {
            this.falsenumber = falsenumber;
        }

        bool IsBadVersion(int n)
        {
            return n >= this.falsenumber;
        }

        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
