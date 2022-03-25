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
    }
}
