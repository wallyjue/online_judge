using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem119
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
            {
                return new List<int> { 1 };
            }

            List<int> prev = new List<int> { 1, 1 };
            List<int> curr = new List<int>();
            for (int i = 2; i < rowIndex + 1; i++)
            {
                curr = new List<int> { 1 };
                for (int j = 1; j < i; j++)
                {
                    curr.Add(prev[j - 1] + prev[j]);
                }
                curr.Add(1);

                prev = curr;
            }

            return prev;
        }
    }
}
