using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            Hashtable table = new Hashtable();
            List<int> ret = new List<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (!table.Contains(nums[i]))
                {
                    table.Add(nums[i], true);
                }
            }

            for (int i = 1; i < nums.Length + 1; i++)
            {
                if (!table.ContainsKey(i))
                {
                    ret.Add(i);
                }
            }

            return ret;
        }

        public IList<int> FindDisappearedNumbers2(int[] nums)
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int nexIndex = Math.Abs(nums[i]) - 1;
                if (nums[nexIndex] > 0)
                {
                    nums[nexIndex] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    ret.Add(i + 1);
                }
            }
            return ret;
        }
    }
}
