using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Hashtable table = new Hashtable();
            for (int cnt = 0; cnt < nums.Length; cnt++)
            {
                if (table.Contains(nums[cnt]))
                {
                    return true;
                }
                else
                {
                    table.Add(nums[cnt], true);
                }
                
            }
            return false;
        }
    }
}
