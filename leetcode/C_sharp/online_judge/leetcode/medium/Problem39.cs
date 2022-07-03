using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem39
    {
        int target;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            this.target = target;
            Hashtable table = new Hashtable();
            List<IList<int>> ret = new List<IList<int>>();
            backtracking(candidates, 0, 0, new List<int>(), ret);
            return ret;
        }

        private void backtracking(int[] candidates, int currentSum, int index, List<int> currentSet, List<IList<int>> results)
        {
            if (currentSum == this.target)
            {
                results.Add(new List<int>(currentSet));
                return;
            }
            else if (currentSum > this.target)
            {
                return;
            }

            for (int start = index; start < candidates.Length;start++)
            {
                currentSet.Add(candidates[start]);
                backtracking(candidates, currentSum + candidates[start], start, currentSet, results);
                currentSet.Remove(currentSet.Last());
            }
        }
    }
}
