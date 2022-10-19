using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem394
    {
        public string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();

            string ret = string.Empty;
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (s[cnt] != ']')
                {
                    stack.Push(s[cnt]);
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    int rep = 0;
                    while (stack.Count > 0 && stack.Peek() > '9' && stack.Peek() < '0')
                    {
                        char c = stack.Pop();
                        if (c != '[')
                        {
                            sb.Append(c);
                        }
                    }

                    rep = int.Parse(stack.Pop().ToString());
                }
            }


            return ret;
        }
    }
}
