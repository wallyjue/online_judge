using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    public class Problem287
    {
        public int FindDuplicate(int[] nums)
        {
            Hashtable table = new Hashtable();
            int ret = 0;
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (table.ContainsKey(nums[cnt]))
                {
                    return nums[cnt];
                }

                if (!table.ContainsKey(nums[cnt])) table.Add(nums[cnt], true);
            }

            return ret;
        }
    }
}
