using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem22
    {
        // dynamic programming function
        // f(n) = (f(n-1)) + ()f(n-1) + f(n-1)();
        Hashtable table;
        public IList<string> GenerateParenthesis(int n)
        {
            table = new Hashtable();
            table.Add(1, new List<string> { "()" });
            if (n == 1)
            {
                return (IList<string>)table[1];
            }

            for(int cnt = 2; cnt <= n; cnt++)
            {
                dynamicProgramming(cnt);
            }

            return (IList<string>)table[n];
        }

        private void dynamicProgramming(int level)
        {
            var prev = (List<string>)table[level - 1];
            var ret = new List<string>();
            foreach (string item in prev)
            {
                ret.Add($"({item})");
                ret.Add($"(){item}");
                ret.Add($"{item}()");
                ret = ret.Distinct().ToList();
            }
            string rep = string.Empty;
            for (int cnt = 0; cnt < level; cnt++)
            {
                rep += "()";
            }

            ret.Remove(rep);
            table.Add(level, ret);
        }
    }
}
