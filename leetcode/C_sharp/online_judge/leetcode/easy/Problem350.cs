using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            List<int> ret = new List<int>();
            if (nums1.Length > nums2.Length)
            {
                for(int cnt = 0; cnt < nums2.Length;cnt++)
                {
                    for (int cnt2 = 0; cnt2 < nums1.Length; cnt2++)
                    {
                        if (nums1[cnt2] == nums2[cnt] && !table.ContainsKey(cnt2))
                        {
                            table[cnt2] = nums2[cnt];
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int cnt = 0; cnt < nums1.Length; cnt++)
                {
                    for (int cnt2 = 0; cnt2 < nums2.Length;cnt2++)
                    {
                        if (nums2[cnt2] == nums1[cnt] && !table.ContainsKey(cnt2))
                        {
                            table[cnt2] = nums1[cnt];
                            break;
                        }
                    }
                    
                }
            }

            foreach(var item in table)
            {
                ret.Add(item.Value);
            }

            return ret.ToArray();
        }
    }
}
