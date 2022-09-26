using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem20
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            bool ret = true;
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                char c;
                if (s[cnt] == '(' || s[cnt] == '[' || s[cnt] == '{')
                {
                    stack.Push(s[cnt]);
                }
                else
                {
                    bool isEmpty = stack.TryPop(out c);
                    if (c == '(' && s[cnt] == ')' || c == '[' && s[cnt] == ']' || c == '{' && s[cnt] == '}')
                    {
                        continue;
                    }
                    else
                    {
                        stack.Push(s[cnt]);
                    }
                }
            }
            return ret && stack.Count == 0;
        }
    }
}
