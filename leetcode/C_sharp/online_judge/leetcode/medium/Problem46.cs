using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> ret = new List<IList<int>>();

            for (int cnt = 0; cnt < nums.Length;cnt++)
            {
                backtracking(nums[cnt], nums);
            }


            return ret;
        }

        private void backtracking(int num, int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }
        }
    }
}
