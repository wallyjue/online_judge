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
            bool isInString = false;
            StringBuilder ret = new StringBuilder();
            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                if (!isInString && s[cnt] >= 'a' && s[cnt] <= 'z')
                {
                    ret.Append(s[cnt]);
                }
                else if (s[cnt] != ']')
                {
                    stack.Push(s[cnt]);
                    isInString = true;
                }
                else
                {
                    isInString = false;
                    StringBuilder sb = new StringBuilder();
                    int rep = 0;
                    var cc = stack.Peek();
                    while (stack.Count > 0 && stack.Peek() > '9')
                    {
                        char c = stack.Pop();
                        if (c != '[')
                        {
                            sb.Append(c);
                        }
                    }

                    rep = int.Parse(stack.Pop().ToString());
                    if (stack.Count == 0)
                    {
                        for (int cnt2 = 0; cnt2 < rep; cnt2++)
                        {
                            for (int cnt3 = sb.Length - 1; cnt3 >= 0; cnt3--)
                            {
                                ret.Append(sb[cnt3]);
                            }
                        }
                    }
                    else
                    {
                        for (int cnt2 = 0; cnt2 < rep; cnt2++)
                        {
                            for (int cnt3 = sb.Length - 1; cnt3 >= 0; cnt3--)
                            {
                                stack.Push(sb[cnt3]);
                            }
                        }
                    }
                }
            }

            return ret.ToString();
        }
    }
}
