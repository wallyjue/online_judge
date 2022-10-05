using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem740
    {
        // dynamic function
        
        public int DeleteAndEarn(int[] nums)
        {
            int[] map = new int[10000];
            for (int cnt = 0;cnt < nums.Length;cnt++)
            {
                map[nums[cnt]] += nums[cnt];
            }

            return 0;
        }
    }
}
