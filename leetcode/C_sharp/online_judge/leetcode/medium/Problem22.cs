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
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            backtracking(result, new StringBuilder(), 0, 0, n);
            return result;
        }

        private void backtracking(List<string> set, StringBuilder sb, int open, int close, int level)
        {
            // ending condition
            if (sb.Length == level * 2)
            {
                set.Add(sb.ToString());
                return;
            }


            if (level > open)
            {
                sb.Append("(");
                backtracking(set, sb, open + 1, close, level);
                sb.Remove(sb.Length - 1, 1);
            }

            if (open > close)
            {
                sb.Append(")");
                backtracking(set, sb, open, close + 1, level);
                sb.Remove(sb.Length - 1, 1);
            }

            
        }
    }
}
