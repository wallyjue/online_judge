using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem90
    {
        IList<IList<int>> ret;
        Hashtable table = new Hashtable();
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            this.ret = new List<IList<int>>();
            this.ret.Add(nums.ToList());
            this.ret.Add((new int[] { }).ToList());
            backtracking(nums.Length - 1, nums);
            return this.ret;
        }

        private void backtracking(int index, int[] addingArray)
        {
            if (addingArray.Length == 0 || index >= addingArray.Length)
            {
                return;
            }

            for (int i = index; i >= 0; i--)
            {
                var list = addingArray.Where((x, idx) => idx != i).ToList();
                //var list = addingArray.Where(x => x != addingArray[i]).ToList();
                
                if (list.Count() == 0)
                {
                    return;
                }

                list.Sort();
                var temp = string.Empty;
                list.ForEach(x => temp += x.ToString());
                if (!table.Contains(temp))
                {
                    this.ret.Add(new List<int>(list));
                    table.Add(temp, 1);
                }
                backtracking(i - 1, list.ToArray());
                list.Add(addingArray[i]);
            }
        }
    }
}
