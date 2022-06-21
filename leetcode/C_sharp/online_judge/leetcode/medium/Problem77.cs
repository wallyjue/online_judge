using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem77
    {
        IList<IList<int>> ret = new List<IList<int>>();
        int n = 0;
        int k = 0;
        public IList<IList<int>> Combine(int n, int k)
        {
            this.n = n;
            this.k = k;
            backtrack(1, new List<int>());
            return ret;
        }

        private void backtrack(int toAdd, List<int> array)
        {
            if (array.Count == this.k)
            {
                this.ret.Add(new List<int>(array));
            }

            for (int cnt = toAdd; cnt < this.n + 1; ++cnt)
            {
                array.Add(cnt);
                backtrack(cnt + 1, array);
                array.RemoveAll(x => x == cnt);
            }
        }
    }
}
