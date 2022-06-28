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

            Hashtable table = new Hashtable();
            Hashtable added = new Hashtable();
            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                if (table[nums[cnt]] == null)
                {
                    table.Add(nums[cnt], new List<int> { cnt });
                }
                else
                {
                    ((List<int>)table[nums[cnt]]).Add(cnt);
                }
            }
            
            for (int x = 0; x < nums.Length; x++)
            {
                for(int y = x + 1; y < nums.Length; y++)
                {
                    if (table.Contains(-1 * (nums[x] + nums[y])) && 
                        !added.Contains((nums[x], nums[y])) &&
                        !added.Contains((nums[y], nums[x])))
                    {
                        List<int> valuelist = (List<int>)table[-1 * (nums[x] + nums[y])];
                        var value =  valuelist.FirstOrDefault(v => v > y, int.MinValue);
                        if (valuelist.Count() > y)
                        {
                            continue;
                        }

                        List<int> list = new List<int>();
                        list.Add(nums[x]);
                        list.Add(nums[y]);
                        list.Add(nums[value]);
                        list.Sort();


                        if (!added.Contains((list[0], list[1])))
                        {
                            ret.Add(list);
                            added.Add((list[0], list[1]), list[2]);
                        }

                    }
                }
            }
            return ret;
        }
    }
}
