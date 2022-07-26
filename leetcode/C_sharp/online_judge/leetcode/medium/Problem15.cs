using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> ret = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return ret;
            }
            for (int x = 0; x < nums.Length; x++)
            {
                if (x == 0 || nums[x - 1] != nums[x])
                {
                    Hashtable table = new Hashtable();
                    for (int y = x + 1; y < nums.Length; y++)
                    {
                        int complement = -nums[x] - nums[y];
                        if (table.Contains(complement))
                        {
                            ret.Add(new List<int> { nums[x] , nums[y], complement });
                            while (y + 1 < nums.Length && nums[y] == nums[y + 1])
                                ++y;
                        }
                        if (!table.Contains(nums[y]))
                        {
                            table.Add(nums[y], y);
                        }
                    }
                }
            }

            return ret;
        }
    }
}
