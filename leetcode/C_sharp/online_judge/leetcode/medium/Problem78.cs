using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem78
    {
        IList<IList<int>> ret;
        public IList<IList<int>> Subsets(int[] nums)
        {
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
                var list = addingArray.Where(x => x != addingArray[i]).ToList();

                if (list.Count() == 0)
                {
                    return;
                }

                this.ret.Add(new List<int>(list));
                backtracking(i - 1, list.ToArray());
                list.Add(addingArray[i]);
            }
        }
    }
}
