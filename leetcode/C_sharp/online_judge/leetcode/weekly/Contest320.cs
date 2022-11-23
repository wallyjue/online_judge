using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.weekly
{
    internal class Contest320
    {
        public int UnequalTriplets(int[] nums)
        {
            int uniqueNum = 0;
            Dictionary<int, List<int>> table = new Dictionary<int, List<int>>();
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (!table.ContainsKey(nums[cnt]))
                {
                    uniqueNum++;
                    table.Add(nums[cnt], new List<int> { cnt });
                }
                else
                {
                    var list = (List<int>)table[nums[cnt]];
                    list.Add(nums[cnt]);

                    table.Remove(nums[cnt]);
                    table.Add(nums[cnt], list);
                }
            }

            int combination = 0;

            if (uniqueNum >= 3)
            {
                combination = 1;
                foreach (var item in table)
                {
                    combination *= item.Value.Count;
                }
            }

            return combination;
        }

        private int Factorial(int num)
        {
            int ret = 1;
            for(int cnt = 1; cnt <= num; cnt++)
            {
                ret *= cnt;
            }
            return ret;
        }
    }
}
